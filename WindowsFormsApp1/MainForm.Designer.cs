namespace SchrutesStitches
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.crossStitch = new System.Windows.Forms.DataGridView();
            this.buttonSetTable = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.labelAddDMC = new System.Windows.Forms.Label();
            this.textBoxDMCEntry = new System.Windows.Forms.TextBox();
            this.labelProjectColors = new System.Windows.Forms.Label();
            this.labelDMCColours = new System.Windows.Forms.Label();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.listViewDMC = new System.Windows.Forms.ListView();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.labelCurrentColor = new System.Windows.Forms.Label();
            this.labelStichTag = new System.Windows.Forms.Label();
            this.textBoxStitchTag = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelColourCode = new System.Windows.Forms.Label();
            this.textBoxHexCode = new System.Windows.Forms.TextBox();
            this.buttonSelectColour = new System.Windows.Forms.Button();
            this.buttonNewColour = new System.Windows.Forms.Button();
            this.listViewColours = new System.Windows.Forms.ListView();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSquaresPerInch = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelSquaresPerInch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewColourChart = new System.Windows.Forms.DataGridView();
            this.KeyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMCColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogFinalProduct = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonErasor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.crossStitch)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSquaresPerInch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColourChart)).BeginInit();
            this.SuspendLayout();
            // 
            // crossStitch
            // 
            this.crossStitch.AllowUserToAddRows = false;
            this.crossStitch.AllowUserToDeleteRows = false;
            this.crossStitch.AllowUserToResizeColumns = false;
            this.crossStitch.AllowUserToResizeRows = false;
            this.crossStitch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crossStitch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.crossStitch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crossStitch.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crossStitch.DefaultCellStyle = dataGridViewCellStyle2;
            this.crossStitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crossStitch.Location = new System.Drawing.Point(0, 0);
            this.crossStitch.MultiSelect = false;
            this.crossStitch.Name = "crossStitch";
            this.crossStitch.ReadOnly = true;
            this.crossStitch.Size = new System.Drawing.Size(970, 561);
            this.crossStitch.TabIndex = 0;
            this.crossStitch.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CrossStitch_CellPainting);
            this.crossStitch.SelectionChanged += new System.EventHandler(this.CrossStitch_SelectionChanged);
            // 
            // buttonSetTable
            // 
            this.buttonSetTable.Location = new System.Drawing.Point(11, 67);
            this.buttonSetTable.Name = "buttonSetTable";
            this.buttonSetTable.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTable.TabIndex = 1;
            this.buttonSetTable.Text = "Set Table 10x10";
            this.buttonSetTable.UseVisualStyleBackColor = true;
            this.buttonSetTable.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.Controls.Add(this.controlPanel, 0, 0);
            this.mainPanel.Controls.Add(this.panel1, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(1018, 567);
            this.mainPanel.TabIndex = 4;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.radioButtonErasor);
            this.controlPanel.Controls.Add(this.labelAddDMC);
            this.controlPanel.Controls.Add(this.textBoxDMCEntry);
            this.controlPanel.Controls.Add(this.labelProjectColors);
            this.controlPanel.Controls.Add(this.labelDMCColours);
            this.controlPanel.Controls.Add(this.buttonRedo);
            this.controlPanel.Controls.Add(this.listViewDMC);
            this.controlPanel.Controls.Add(this.buttonUndo);
            this.controlPanel.Controls.Add(this.labelCurrentColor);
            this.controlPanel.Controls.Add(this.labelStichTag);
            this.controlPanel.Controls.Add(this.textBoxStitchTag);
            this.controlPanel.Controls.Add(this.labelName);
            this.controlPanel.Controls.Add(this.textBoxName);
            this.controlPanel.Controls.Add(this.labelColourCode);
            this.controlPanel.Controls.Add(this.textBoxHexCode);
            this.controlPanel.Controls.Add(this.buttonSelectColour);
            this.controlPanel.Controls.Add(this.buttonNewColour);
            this.controlPanel.Controls.Add(this.listViewColours);
            this.controlPanel.Controls.Add(this.buttonZoomOut);
            this.controlPanel.Controls.Add(this.buttonZoomIn);
            this.controlPanel.Controls.Add(this.numericUpDownHeight);
            this.controlPanel.Controls.Add(this.numericUpDownWidth);
            this.controlPanel.Controls.Add(this.numericUpDownSquaresPerInch);
            this.controlPanel.Controls.Add(this.labelHeight);
            this.controlPanel.Controls.Add(this.labelWidth);
            this.controlPanel.Controls.Add(this.labelSquaresPerInch);
            this.controlPanel.Controls.Add(this.buttonSetTable);
            this.controlPanel.Controls.Add(this.menuStrip1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(3, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(294, 561);
            this.controlPanel.TabIndex = 0;
            // 
            // labelAddDMC
            // 
            this.labelAddDMC.AutoSize = true;
            this.labelAddDMC.Location = new System.Drawing.Point(87, 537);
            this.labelAddDMC.Name = "labelAddDMC";
            this.labelAddDMC.Size = new System.Drawing.Size(84, 13);
            this.labelAddDMC.TabIndex = 33;
            this.labelAddDMC.Text = "Add DMC Code:";
            // 
            // textBoxDMCEntry
            // 
            this.textBoxDMCEntry.Location = new System.Drawing.Point(175, 534);
            this.textBoxDMCEntry.Name = "textBoxDMCEntry";
            this.textBoxDMCEntry.Size = new System.Drawing.Size(100, 20);
            this.textBoxDMCEntry.TabIndex = 32;
            this.textBoxDMCEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // labelProjectColors
            // 
            this.labelProjectColors.AutoSize = true;
            this.labelProjectColors.Location = new System.Drawing.Point(17, 231);
            this.labelProjectColors.Name = "labelProjectColors";
            this.labelProjectColors.Size = new System.Drawing.Size(210, 13);
            this.labelProjectColors.TabIndex = 31;
            this.labelProjectColors.Text = "Project Colors: Double right click to remove";
            // 
            // labelDMCColours
            // 
            this.labelDMCColours.AutoSize = true;
            this.labelDMCColours.Location = new System.Drawing.Point(18, 392);
            this.labelDMCColours.Name = "labelDMCColours";
            this.labelDMCColours.Size = new System.Drawing.Size(208, 13);
            this.labelDMCColours.TabIndex = 30;
            this.labelDMCColours.Text = "DMC Colors: Double click to add to project";
            // 
            // buttonRedo
            // 
            this.buttonRedo.Enabled = false;
            this.buttonRedo.Location = new System.Drawing.Point(130, 96);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(44, 23);
            this.buttonRedo.TabIndex = 29;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // listViewDMC
            // 
            this.listViewDMC.HideSelection = false;
            this.listViewDMC.Location = new System.Drawing.Point(9, 408);
            this.listViewDMC.MultiSelect = false;
            this.listViewDMC.Name = "listViewDMC";
            this.listViewDMC.Size = new System.Drawing.Size(271, 122);
            this.listViewDMC.TabIndex = 28;
            this.listViewDMC.Tag = "4";
            this.listViewDMC.UseCompatibleStateImageBehavior = false;
            this.listViewDMC.DoubleClick += new System.EventHandler(this.ListViewDMC_DoubleClick);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Location = new System.Drawing.Point(130, 67);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(44, 23);
            this.buttonUndo.TabIndex = 25;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // labelCurrentColor
            // 
            this.labelCurrentColor.AutoSize = true;
            this.labelCurrentColor.Location = new System.Drawing.Point(18, 148);
            this.labelCurrentColor.Name = "labelCurrentColor";
            this.labelCurrentColor.Size = new System.Drawing.Size(68, 13);
            this.labelCurrentColor.TabIndex = 23;
            this.labelCurrentColor.Text = "Current Color";
            // 
            // labelStichTag
            // 
            this.labelStichTag.AutoSize = true;
            this.labelStichTag.Location = new System.Drawing.Point(102, 178);
            this.labelStichTag.Name = "labelStichTag";
            this.labelStichTag.Size = new System.Drawing.Size(74, 13);
            this.labelStichTag.TabIndex = 22;
            this.labelStichTag.Text = "Color Number:";
            this.labelStichTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStitchTag
            // 
            this.textBoxStitchTag.Location = new System.Drawing.Point(182, 175);
            this.textBoxStitchTag.Name = "textBoxStitchTag";
            this.textBoxStitchTag.Size = new System.Drawing.Size(100, 20);
            this.textBoxStitchTag.TabIndex = 21;
            this.textBoxStitchTag.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(111, 153);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 13);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Color Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(182, 150);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // labelColourCode
            // 
            this.labelColourCode.AutoSize = true;
            this.labelColourCode.Location = new System.Drawing.Point(92, 202);
            this.labelColourCode.Name = "labelColourCode";
            this.labelColourCode.Size = new System.Drawing.Size(84, 13);
            this.labelColourCode.TabIndex = 18;
            this.labelColourCode.Text = "Color Hex Code:";
            this.labelColourCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxHexCode
            // 
            this.textBoxHexCode.Location = new System.Drawing.Point(182, 199);
            this.textBoxHexCode.Name = "textBoxHexCode";
            this.textBoxHexCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxHexCode.TabIndex = 17;
            this.textBoxHexCode.Leave += new System.EventHandler(this.TextBoxHexCode_Leave);
            // 
            // buttonSelectColour
            // 
            this.buttonSelectColour.Location = new System.Drawing.Point(13, 196);
            this.buttonSelectColour.Name = "buttonSelectColour";
            this.buttonSelectColour.Size = new System.Drawing.Size(76, 23);
            this.buttonSelectColour.TabIndex = 16;
            this.buttonSelectColour.Text = "Pick Color";
            this.buttonSelectColour.UseVisualStyleBackColor = true;
            this.buttonSelectColour.Click += new System.EventHandler(this.ButtonSelectColour_Click);
            // 
            // buttonNewColour
            // 
            this.buttonNewColour.Location = new System.Drawing.Point(14, 168);
            this.buttonNewColour.Name = "buttonNewColour";
            this.buttonNewColour.Size = new System.Drawing.Size(75, 23);
            this.buttonNewColour.TabIndex = 15;
            this.buttonNewColour.Text = "New Color";
            this.buttonNewColour.UseVisualStyleBackColor = true;
            this.buttonNewColour.Click += new System.EventHandler(this.ButtonNewColour_Click);
            // 
            // listViewColours
            // 
            this.listViewColours.HideSelection = false;
            this.listViewColours.Location = new System.Drawing.Point(9, 247);
            this.listViewColours.MultiSelect = false;
            this.listViewColours.Name = "listViewColours";
            this.listViewColours.Size = new System.Drawing.Size(273, 133);
            this.listViewColours.TabIndex = 14;
            this.listViewColours.Tag = "4";
            this.listViewColours.UseCompatibleStateImageBehavior = false;
            this.listViewColours.SelectedIndexChanged += new System.EventHandler(this.ListViewColours_SelectedIndexChanged);
            this.listViewColours.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewColours_MouseDoubleClick);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(180, 96);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(75, 23);
            this.buttonZoomOut.TabIndex = 13;
            this.buttonZoomOut.Text = "Zoom Out";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.ButtonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(180, 67);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(75, 23);
            this.buttonZoomIn.TabIndex = 12;
            this.buttonZoomIn.Text = "Zoom In";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.ButtonZoomIn_Click);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(251, 30);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownHeight.TabIndex = 11;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.NumericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(171, 30);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownWidth.TabIndex = 10;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.NumericUpDownWidth_ValueChanged);
            // 
            // numericUpDownSquaresPerInch
            // 
            this.numericUpDownSquaresPerInch.Location = new System.Drawing.Point(90, 30);
            this.numericUpDownSquaresPerInch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSquaresPerInch.Name = "numericUpDownSquaresPerInch";
            this.numericUpDownSquaresPerInch.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSquaresPerInch.TabIndex = 9;
            this.numericUpDownSquaresPerInch.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownSquaresPerInch.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(211, 32);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(133, 32);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Width:";
            // 
            // labelSquaresPerInch
            // 
            this.labelSquaresPerInch.AutoSize = true;
            this.labelSquaresPerInch.Location = new System.Drawing.Point(1, 32);
            this.labelSquaresPerInch.Name = "labelSquaresPerInch";
            this.labelSquaresPerInch.Size = new System.Drawing.Size(89, 13);
            this.labelSquaresPerInch.TabIndex = 4;
            this.labelSquaresPerInch.Text = "Stitches per inch:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.saveProjectAsPictureToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProjectToolStripMenuItem_Click);
            // 
            // saveProjectAsPictureToolStripMenuItem
            // 
            this.saveProjectAsPictureToolStripMenuItem.Name = "saveProjectAsPictureToolStripMenuItem";
            this.saveProjectAsPictureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveProjectAsPictureToolStripMenuItem.Text = "Save Project as Picture";
            this.saveProjectAsPictureToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectAsPictureToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewColourChart);
            this.panel1.Controls.Add(this.crossStitch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(303, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 561);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewColourChart
            // 
            this.dataGridViewColourChart.AllowUserToAddRows = false;
            this.dataGridViewColourChart.AllowUserToDeleteRows = false;
            this.dataGridViewColourChart.AllowUserToResizeColumns = false;
            this.dataGridViewColourChart.AllowUserToResizeRows = false;
            this.dataGridViewColourChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColourChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyColumn,
            this.DMCColumn,
            this.NameColumn});
            this.dataGridViewColourChart.Location = new System.Drawing.Point(349, 3);
            this.dataGridViewColourChart.Name = "dataGridViewColourChart";
            this.dataGridViewColourChart.ReadOnly = true;
            this.dataGridViewColourChart.RowHeadersVisible = false;
            this.dataGridViewColourChart.Size = new System.Drawing.Size(354, 93);
            this.dataGridViewColourChart.TabIndex = 1;
            this.dataGridViewColourChart.Visible = false;
            // 
            // KeyColumn
            // 
            this.KeyColumn.HeaderText = "Key";
            this.KeyColumn.Name = "KeyColumn";
            this.KeyColumn.ReadOnly = true;
            // 
            // DMCColumn
            // 
            this.DMCColumn.HeaderText = "Stitch Code";
            this.DMCColumn.Name = "DMCColumn";
            this.DMCColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Schrute Stich (*.schrute)|*.schrute";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Schrute Stich (*.schrute)|*.schrute";
            // 
            // saveFileDialogFinalProduct
            // 
            this.saveFileDialogFinalProduct.Filter = "Image (*.png)|*.png";
            // 
            // radioButtonErasor
            // 
            this.radioButtonErasor.AutoSize = true;
            this.radioButtonErasor.Location = new System.Drawing.Point(21, 99);
            this.radioButtonErasor.Name = "radioButtonErasor";
            this.radioButtonErasor.Size = new System.Drawing.Size(56, 17);
            this.radioButtonErasor.TabIndex = 35;
            this.radioButtonErasor.TabStop = true;
            this.radioButtonErasor.Text = "Yeeter";
            this.radioButtonErasor.UseVisualStyleBackColor = true;
            this.radioButtonErasor.CheckedChanged += new System.EventHandler(this.RadioButtonErasor_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 567);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Schrutes Stitches";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.crossStitch)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSquaresPerInch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColourChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView crossStitch;
        private System.Windows.Forms.Button buttonSetTable;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label labelSquaresPerInch;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownSquaresPerInch;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonNewColour;
        private System.Windows.Forms.ListView listViewColours;
        private System.Windows.Forms.TextBox textBoxHexCode;
        private System.Windows.Forms.Button buttonSelectColour;
        private System.Windows.Forms.Label labelColourCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelStichTag;
        private System.Windows.Forms.TextBox textBoxStitchTag;
        private System.Windows.Forms.Label labelCurrentColor;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFinalProduct;
        private System.Windows.Forms.ListView listViewDMC;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Label labelProjectColors;
        private System.Windows.Forms.Label labelDMCColours;
        private System.Windows.Forms.DataGridView dataGridViewColourChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMCColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Label labelAddDMC;
        private System.Windows.Forms.TextBox textBoxDMCEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsPictureToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonErasor;
    }
}

