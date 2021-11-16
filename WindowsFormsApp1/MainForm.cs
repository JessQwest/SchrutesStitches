using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Collections;

namespace SchrutesStitches
{
    public partial class mainForm : Form
    {
        bool eraseMode = false;

        Stack undoStack = new Stack();
        Stack redoStack = new Stack();
        private class Action
        {
            public int row;
            public int col;
            public Color oldColor;
            public Color newColor;

            public Action(int r, int c, Color oldc, Color newc)
            {
                row = r;
                col = c;
                oldColor = oldc;
                newColor = newc;
            }
        }

        int squaresPerInch = 16;
        int width = 5;
        int height = 7;

        bool init = false;

        Color currentColour;

        Font mainFont;

        public mainForm()
        {
            InitializeComponent();
        }

        public new void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        private void NewTable()
        {
            if (width < 1)
            {
                width = 1;
                numericUpDownWidth.Value = 1;
            }
            if (height < 1)
            {
                height = 1;
                numericUpDownHeight.Value = 1;
            }
            if (squaresPerInch < 1)
            {
                squaresPerInch = 1;
                numericUpDownSquaresPerInch.Value = 1;
            }
            init = false;
            DoubleBuffered(crossStitch, true);
            crossStitch.Rows.Clear();
            crossStitch.Columns.Clear();
            crossStitch.DataSource = null;
            for (int i = 0; i < width * squaresPerInch; i++)
            {
                DataGridViewTextBoxColumn d = new DataGridViewTextBoxColumn();
                d.Width = 25;
                crossStitch.Columns.Add(d);
            }
            for (int i = 0; i < height * squaresPerInch; i++)
            {
                crossStitch.Rows.Add();
            }
            mainFont = crossStitch[0, 0].Style.Font;
            resizeTable();

        }

        private void ClearBoxes()
        {
            listViewColours.SelectedItems.Clear();
            textBoxHexCode.Text = "";
            textBoxStitchTag.Text = "";
            textBoxName.Text = "";
            labelCurrentColor.BackColor = Color.Empty;
            currentColour = new Color();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to clear the graph and create a new stitch?", "Schrutes Stiches", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewTable();
            }
        }
        private void CrossStitch_SelectionChanged(object sender, EventArgs e)
        {
            crossStitch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            crossStitch.RowHeadersVisible = false;
            foreach (DataGridViewTextBoxCell s in crossStitch.SelectedCells)
            {
                if (init)
                {
                    if ((currentColour != null && currentColour != Color.Empty) || eraseMode)
                    {
                        undoStack.Push(new Action(s.RowIndex, s.ColumnIndex, s.Style.BackColor, currentColour));
                        redoStack.Clear();
                        buttonRedo.Enabled = false;
                        buttonUndo.Enabled = true;
                        s.Style.BackColor = currentColour;
                    }
                }
            }
            //crossStitch.ClearSelection();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            squaresPerInch = Decimal.ToInt32(numericUpDownSquaresPerInch.Value);
        }

        private void NumericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            width = Decimal.ToInt32(numericUpDownWidth.Value);
        }

        private void NumericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            height = Decimal.ToInt32(numericUpDownHeight.Value);
        }

        private int size = 20;

        private void resizeTable()
        {
            if (size < 0)
            {
                size = 0;
            }
            for (int i = 0; i < crossStitch.ColumnCount; i++)
            {
                crossStitch.Columns[i].Width = size;
            }
            for (int i = 0; i < crossStitch.RowCount; i++)
            {
                crossStitch.Rows[i].Height = size;
            }

            crossStitch.ClearSelection();
            init = true;
        }

        private void ButtonZoomIn_Click(object sender, EventArgs e)
        {
            size = size + 5;
            resizeTable();
        }

        private void ButtonZoomOut_Click(object sender, EventArgs e)
        {
            size = size - 5;
            resizeTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            crossStitch.ClearSelection();
            if (!File.Exists("DMC.dat"))
            {
                File.WriteAllBytes("DMC.dat", Properties.Resources.DMC);
            }
            foreach (string line in System.IO.File.ReadLines("DMC.dat"))
            {
                string[] values = line.Split(',');
                ListViewItem newColour = new ListViewItem(values[0]);
                newColour.BackColor = Color.FromArgb(Int32.Parse(values[2]));
                newColour.ToolTipText = values[1];
                listViewDMC.Items.Add(newColour);
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'u')
            {
                buttonNewColour.Text = "New Colour";
                buttonSelectColour.Text = "Pick Colour";
                labelColourCode.Text = "Colour Hex Code:";
                labelName.Text = "Colour Name:";
                labelProjectColors.Text = "Project Colours: Double right click to remove";
                labelDMCColours.Text = "DMC Colours: Double click to add to project";
                labelCurrentColor.Text = "Current Colour";
                labelStichTag.Text = "Colour Number:";
            }
        }

        private void ButtonNewColour_Click(object sender, EventArgs e)
        {
            ListViewItem newColour = new ListViewItem("New Color");
            newColour.BackColor = ColorTranslator.FromHtml("#F00D45");
            newColour.ToolTipText = "23";
            listViewColours.Items.Add(newColour);
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private ListViewItem GetSelectedColour()
        {
            if (listViewColours.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedColour in listViewColours.SelectedItems)
                {
                    return selectedColour;
                }
            }
            return null;
        }

        private void updateSelectedColour()
        {
            ListViewItem selection = GetSelectedColour();
            if (selection != null)
            {
                textBoxName.Text = selection.Text;
                labelCurrentColor.BackColor = selection.BackColor;
                textBoxStitchTag.Text = selection.ToolTipText;
                textBoxHexCode.Text = HexConverter(selection.BackColor);
                currentColour = selection.BackColor;
                eraseMode = false;
                radioButtonErasor.Checked = false;
            }
        }

        private void ListViewColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedColour();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (listViewColours.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedColour in listViewColours.SelectedItems)
                {
                    selectedColour.Text = textBoxName.Text;
                }
            }
        }

        private void ButtonSelectColour_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selection = GetSelectedColour();
                if (selection != null)
                {
                    selection.BackColor = colorDialog.Color;
                    labelCurrentColor.BackColor = selection.BackColor;
                    updateSelectedColour();
                }
            }
        }

        private void TextBoxHexCode_Leave(object sender, EventArgs e)
        {
            int index = textBoxHexCode.SelectionStart;
            string newColor = textBoxHexCode.Text;
            newColor = newColor.Replace("#", "");
            ListViewItem selection = GetSelectedColour();
            if (selection != null)
            {
                try
                {
                    if (ColorTranslator.FromHtml("#" + newColor) != Color.Black)
                    {
                        selection.BackColor = ColorTranslator.FromHtml("#" + newColor);
                        updateSelectedColour();
                        textBoxHexCode.SelectionStart = index;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ListViewItem selection = GetSelectedColour();
            if (selection != null)
            {
                selection.ToolTipText = textBoxStitchTag.Text;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                crossStitch.ClearSelection();
                Action action = (Action)undoStack.Pop();
                crossStitch[action.col, action.row].Style.BackColor = action.oldColor;
                redoStack.Push(action);
                buttonRedo.Enabled = true;
                if (undoStack.Count == 0)
                {
                    buttonUndo.Enabled = false;
                }
            }
        }

        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                crossStitch.ClearSelection();
                Action action = (Action)redoStack.Pop();
                crossStitch[action.col, action.row].Style.BackColor = action.newColor;
                undoStack.Push(action);
                buttonUndo.Enabled = true;
                if (redoStack.Count == 0)
                {
                    buttonRedo.Enabled = false;
                }
            }
        }

        private void ButtonSaveProject_Click(object sender, EventArgs e)
        {
            
        }

        private void CrossStitch_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewCellStyle style = e.CellStyle;
            Rectangle leftLine = new Rectangle(e.CellBounds.X,
                e.CellBounds.Y, 1,
                e.CellBounds.Height);
            Rectangle topLine = new Rectangle(e.CellBounds.X,
                e.CellBounds.Y, e.CellBounds.Width,
                1);
            Rectangle rightLine = new Rectangle(e.CellBounds.X + e.CellBounds.Width-3,
                e.CellBounds.Y, 1,
                e.CellBounds.Height);
            Rectangle bottomLine = new Rectangle(e.CellBounds.X,
                e.CellBounds.Y + e.CellBounds.Height-3, e.CellBounds.Width,
                1);
            using (
                Brush gridBrush = new SolidBrush(this.crossStitch.GridColor),
                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
            {
                using (Pen gridLinePen = new Pen(gridBrush))
                {
                    // Erase the cell.

                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    e.CellStyle.BackColor = Color.Red;
                    // Draw the grid lines (only the right and bottom lines;
                    // DataGridView takes care of the others).
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                        e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                        e.CellBounds.Bottom - 1);
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                        e.CellBounds.Top, e.CellBounds.Right - 1,
                        e.CellBounds.Bottom);

                    // Draw the inset highlight box.



                    // Draw the text content of the cell, ignoring alignment.

                    StringFormat centredFormat = StringFormat.GenericDefault;
                    centredFormat.Alignment = StringAlignment.Center;
                    centredFormat.LineAlignment = StringAlignment.Center;

                    if (e.Value != null)
                    {
                        e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                            Brushes.Black, e.CellBounds, centredFormat);
                    }
                    //paint left line every squaresperinch
                    if ((e.ColumnIndex) % squaresPerInch == 0 && e.RowIndex >= 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, leftLine);
                    }
                    //paint top line ever squaresperinch
                    if ((e.RowIndex) % squaresPerInch == 0 && e.ColumnIndex >= 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, topLine);
                    }
                    //paint right line at far right
                    if ((e.ColumnIndex) == (width*squaresPerInch) -1 && e.ColumnIndex >= 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, rightLine);
                    }
                    //paint bottom line at far right
                    if ((e.RowIndex) == (height * squaresPerInch) - 1 && e.ColumnIndex >= 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, bottomLine);
                    }
                    //paint center vertical line
                    if (e.ColumnIndex * 2 == crossStitch.ColumnCount && e.RowIndex >= (crossStitch.RowCount / 2) - 1 && e.RowIndex <= (crossStitch.RowCount / 2))
                    {
                        e.Graphics.DrawRectangle(Pens.Green, leftLine);
                    }
                    //paint centre horizontal line
                    if (e.RowIndex * 2 == crossStitch.RowCount && e.ColumnIndex >= (crossStitch.ColumnCount / 2) - 1 && e.ColumnIndex <= (crossStitch.ColumnCount / 2))
                    {
                        e.Graphics.DrawRectangle(Pens.Green, topLine);
                    }
                    e.Handled = true;
                }
            }
        }

        private void ListViewDMC_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem colour = listViewDMC.SelectedItems[0];
            ListViewItem newColour = new ListViewItem();
            newColour.Text = colour.Text;
            newColour.BackColor = colour.BackColor;
            newColour.ToolTipText = colour.ToolTipText;
            listViewColours.Items.Add(newColour);
            listViewColours.Items[listViewColours.Items.Count - 1].Selected = true;
            listViewColours.Select();
        }

        private void ListViewColours_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem colour = listViewColours.SelectedItems[0];
                colour.Remove();
                ClearBoxes();
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            
        }


        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (ListViewItem item in listViewDMC.Items)
                {
                    if (item.ToolTipText == textBoxDMCEntry.Text.ToUpper())
                    {
                        ListViewItem newColour = new ListViewItem();
                        newColour.Text = item.Text;
                        newColour.BackColor = item.BackColor;
                        newColour.ToolTipText = item.ToolTipText;
                        listViewColours.Items.Add(newColour);
                        listViewColours.Items[listViewColours.Items.Count - 1].Selected = true;
                        listViewColours.Select();
                        textBoxDMCEntry.Clear();
                        break;
                    }
                }
            }
        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crossStitch.RowCount == 0)
            {
                MessageBox.Show("Theres nothing to save!");
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathToSave = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(pathToSave))
                {
                    string settingsLine = squaresPerInch + "," + width + "," + height;
                    for (int i = 0; i < listViewColours.Items.Count; i++)
                    {
                        settingsLine = settingsLine + "," + listViewColours.Items[i].Text + "," + listViewColours.Items[i].ToolTipText + "," + listViewColours.Items[i].BackColor.ToArgb();
                    }

                    writer.WriteLine(settingsLine);
                    for (int row = 0; row < crossStitch.Rows.Count; row++)
                    {
                        string lineToWrite = "";
                        for (int col = 0; col < crossStitch.Columns.Count; col++)
                        {
                            if (crossStitch[col, row].Style.BackColor == Color.Empty)
                            {
                                lineToWrite = lineToWrite + "x,";
                            }
                            else
                            {
                                lineToWrite = lineToWrite + crossStitch[col, row].Style.BackColor.ToArgb() + ",";
                            }
                        }
                        lineToWrite = lineToWrite.Remove(lineToWrite.Length - 1, 1);
                        writer.WriteLine(lineToWrite);
                    }
                    writer.Close();
                }
                ClearBoxes();
            }
        }

        private void LoadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileToRead = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(fileToRead);
                string[] coreValues = lines[0].Split(',');
                listViewColours.Clear();
                for (int i = 1; i < coreValues.Length / 3; i++)
                {
                    ListViewItem newitem = new ListViewItem();
                    newitem.Text = coreValues[i * 3];
                    newitem.ToolTipText = coreValues[(i * 3) + 1];
                    newitem.BackColor = Color.FromArgb(Int32.Parse(coreValues[(i * 3) + 2]));
                    listViewColours.Items.Add(newitem);
                }
                squaresPerInch = Int32.Parse(coreValues[0]);
                width = Int32.Parse(coreValues[1]);
                height = Int32.Parse(coreValues[2]);
                NewTable();

                for (int row = 1; row < lines.Length; row++)
                {
                    string[] rowValues = lines[row].Split(',');
                    for (int col = 0; col < rowValues.Length; col++)
                    {
                        Color a;
                        if (rowValues[col] != "x")
                        {
                            a = Color.FromArgb(Int32.Parse(rowValues[col]));
                            crossStitch[col, row - 1].Style.BackColor = a;
                        }
                    }
                }
                ClearBoxes();
            }
        }

        private void SaveProjectAsPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crossStitch.RowCount == 0)
            {
                MessageBox.Show("Theres nothing to save!");
                return;
            }
            if (saveFileDialogFinalProduct.ShowDialog() == DialogResult.OK)
            {
                size = 15;
                resizeTable();
                dataGridViewColourChart.Rows.Clear();
                crossStitch.ClearSelection();
                crossStitch.Dock = DockStyle.None;
                string codes = "0123456789ABCDEFGHJKLMNPQRSTUVWXY#!$£&^*+=-{}/⊠@~¬|∎ѠϞψȸĦ¶§¥¤¢";
                int index = 0;
                Dictionary<Color, char> colourKey = new Dictionary<Color, char>();
                for (int col = 0; col < crossStitch.Columns.Count; col++)
                {
                    for (int row = 0; row < crossStitch.Rows.Count; row++)
                    {
                        char key;
                        Color currentColour = crossStitch[col, row].Style.BackColor;
                        if (currentColour != Color.Empty)
                        {
                            if (colourKey.ContainsKey(currentColour))
                            {
                                key = colourKey[currentColour];
                            }
                            else
                            {
                                colourKey.Add(currentColour, codes[index]);
                                index++;
                                key = colourKey[currentColour];
                            }
                            crossStitch[col, row].Value = key.ToString();
                        }
                    }
                }

                foreach (KeyValuePair<Color, char> entry in colourKey)
                {
                    String stitchCode = "???";
                    String name = "???";
                    foreach (ListViewItem item in listViewColours.Items)
                    {
                        if (item.BackColor == entry.Key)
                        {
                            stitchCode = item.ToolTipText;
                            name = item.Text;
                            break;
                        }
                    }
                    if (stitchCode == "???")
                    {
                        foreach (ListViewItem item in listViewDMC.Items)
                        {
                            if (item.BackColor == entry.Key)
                            {
                                stitchCode = item.ToolTipText;
                                name = item.Text;
                                break;
                            }
                        }
                    }

                    if (entry.Key != Color.Empty)
                    {
                        dataGridViewColourChart.Rows.Add(entry.Value, stitchCode, name);
                        dataGridViewColourChart[2, dataGridViewColourChart.RowCount - 1].Style.BackColor = entry.Key;
                    }
                }

                dataGridViewColourChart.Height = dataGridViewColourChart.RowCount * dataGridViewColourChart.Rows[0].Height + 28;
                dataGridViewColourChart.ClearSelection();
                Bitmap bitmapColourChart = new Bitmap(this.dataGridViewColourChart.Width, this.dataGridViewColourChart.Height);
                dataGridViewColourChart.DrawToBitmap(bitmapColourChart, new Rectangle(0, 0, this.dataGridViewColourChart.Width, this.dataGridViewColourChart.Height));
                bitmapColourChart.Save(saveFileDialogFinalProduct.FileName.Substring(0, saveFileDialogFinalProduct.FileName.Length - 4) + "ColorChart.png");

                //Resize DataGridView to full height.
                int height = crossStitch.Height;
                crossStitch.Height = crossStitch.RowCount * crossStitch.Rows[0].Height + 2;

                int width = crossStitch.Width;
                crossStitch.Width = crossStitch.ColumnCount * crossStitch.Columns[0].Width + 2;

                //Create a Bitmap and draw the DataGridView on it.
                Bitmap bitmap = new Bitmap(this.crossStitch.Width, this.crossStitch.Height);
                crossStitch.DrawToBitmap(bitmap, new Rectangle(0, 0, this.crossStitch.Width, this.crossStitch.Height));

                //Resize DataGridView back to original height.
                crossStitch.Height = height;
                crossStitch.Width = width;
                crossStitch.Dock = DockStyle.Fill;
                //Save the Bitmap to folder.
                bitmap.Save(saveFileDialogFinalProduct.FileName);
                for (int col = 0; col < crossStitch.Columns.Count; col++)
                {
                    for (int row = 0; row < crossStitch.Rows.Count; row++)
                    {
                        crossStitch[col, row].Value = "";
                    }
                }
                System.Diagnostics.Process.Start(saveFileDialogFinalProduct.FileName);
                System.Diagnostics.Process.Start(saveFileDialogFinalProduct.FileName.Substring(0, saveFileDialogFinalProduct.FileName.Length - 4) + "ColorChart.png");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (crossStitch.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Would you like to close? Make sure you saved your work first dingus.", "Schrutes Stiches", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void RadioButtonErasor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonErasor.Checked == true)
            {
                currentColour = Color.Empty;
                eraseMode = true;
                listViewColours.SelectedItems.Clear();
            }
        }
    }
}
