namespace DiceRollerWinForms
{
    partial class DiceRollerUserControl
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.historyView = new System.Windows.Forms.ListView();
            this.columnHistory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rollTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.rollPlusButton9 = new System.Windows.Forms.Button();
            this.rollCountBox9 = new System.Windows.Forms.TextBox();
            this.rollMinButton9 = new System.Windows.Forms.Button();
            this.rollPlusButton8 = new System.Windows.Forms.Button();
            this.rollCountBox8 = new System.Windows.Forms.TextBox();
            this.rollMinButton8 = new System.Windows.Forms.Button();
            this.rollPlusButtion7 = new System.Windows.Forms.Button();
            this.rollCountBox7 = new System.Windows.Forms.TextBox();
            this.rollMinButton7 = new System.Windows.Forms.Button();
            this.rollTitleBox9 = new System.Windows.Forms.TextBox();
            this.rollTitleBox8 = new System.Windows.Forms.TextBox();
            this.rollTitleBox7 = new System.Windows.Forms.TextBox();
            this.rollPlusButtion6 = new System.Windows.Forms.Button();
            this.rollCountBox6 = new System.Windows.Forms.TextBox();
            this.rollMinButton6 = new System.Windows.Forms.Button();
            this.rollPlusButton5 = new System.Windows.Forms.Button();
            this.rollCountBox5 = new System.Windows.Forms.TextBox();
            this.rollMinButton5 = new System.Windows.Forms.Button();
            this.rollPlusButton4 = new System.Windows.Forms.Button();
            this.rollCountBox4 = new System.Windows.Forms.TextBox();
            this.rollMinButton4 = new System.Windows.Forms.Button();
            this.rollTitleBox6 = new System.Windows.Forms.TextBox();
            this.rollTitleBox5 = new System.Windows.Forms.TextBox();
            this.rollTitleBox4 = new System.Windows.Forms.TextBox();
            this.rollPlusButton3 = new System.Windows.Forms.Button();
            this.rollCountBox3 = new System.Windows.Forms.TextBox();
            this.rollMinButton3 = new System.Windows.Forms.Button();
            this.rollPlusButton2 = new System.Windows.Forms.Button();
            this.rollCountBox2 = new System.Windows.Forms.TextBox();
            this.rollMinButton2 = new System.Windows.Forms.Button();
            this.rollTitleBox3 = new System.Windows.Forms.TextBox();
            this.rollTitleBox2 = new System.Windows.Forms.TextBox();
            this.rollTitleBox1 = new System.Windows.Forms.TextBox();
            this.rollMinButton1 = new System.Windows.Forms.Button();
            this.rollPlusButton1 = new System.Windows.Forms.Button();
            this.rollCountBox1 = new System.Windows.Forms.TextBox();
            this.rollDiceButton1 = new System.Windows.Forms.Button();
            this.rollDiceButton2 = new System.Windows.Forms.Button();
            this.rollDiceButton3 = new System.Windows.Forms.Button();
            this.rollDiceButton4 = new System.Windows.Forms.Button();
            this.rollDiceButton5 = new System.Windows.Forms.Button();
            this.rollDiceButton6 = new System.Windows.Forms.Button();
            this.rollDiceButton7 = new System.Windows.Forms.Button();
            this.rollDiceButton8 = new System.Windows.Forms.Button();
            this.rollDiceButton9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel1.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            this.rollTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.leftSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.historyView);
            this.mainSplitContainer.Size = new System.Drawing.Size(1623, 860);
            this.mainSplitContainer.SplitterDistance = 1323;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
            // 
            // historyView
            // 
            this.historyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHistory});
            this.historyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyView.Location = new System.Drawing.Point(0, 0);
            this.historyView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.historyView.Name = "historyView";
            this.historyView.Size = new System.Drawing.Size(294, 856);
            this.historyView.TabIndex = 0;
            this.historyView.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "Save";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // leftSplitContainer
            // 
            this.leftSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.leftSplitContainer.Name = "leftSplitContainer";
            this.leftSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftSplitContainer.Panel1
            // 
            this.leftSplitContainer.Panel1.Controls.Add(this.rollTablePanel);
            this.leftSplitContainer.Size = new System.Drawing.Size(1323, 860);
            this.leftSplitContainer.SplitterDistance = 522;
            this.leftSplitContainer.TabIndex = 1;
            // 
            // rollTablePanel
            // 
            this.rollTablePanel.ColumnCount = 9;
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rollTablePanel.Controls.Add(this.rollDiceButton9, 7, 8);
            this.rollTablePanel.Controls.Add(this.rollDiceButton8, 4, 8);
            this.rollTablePanel.Controls.Add(this.rollDiceButton7, 1, 8);
            this.rollTablePanel.Controls.Add(this.rollDiceButton6, 7, 5);
            this.rollTablePanel.Controls.Add(this.rollDiceButton5, 4, 5);
            this.rollTablePanel.Controls.Add(this.rollDiceButton4, 1, 5);
            this.rollTablePanel.Controls.Add(this.rollDiceButton3, 7, 2);
            this.rollTablePanel.Controls.Add(this.rollDiceButton2, 4, 2);
            this.rollTablePanel.Controls.Add(this.rollPlusButton9, 8, 7);
            this.rollTablePanel.Controls.Add(this.rollCountBox9, 7, 7);
            this.rollTablePanel.Controls.Add(this.rollMinButton9, 6, 7);
            this.rollTablePanel.Controls.Add(this.rollPlusButton8, 5, 7);
            this.rollTablePanel.Controls.Add(this.rollCountBox8, 4, 7);
            this.rollTablePanel.Controls.Add(this.rollMinButton8, 3, 7);
            this.rollTablePanel.Controls.Add(this.rollPlusButtion7, 2, 7);
            this.rollTablePanel.Controls.Add(this.rollCountBox7, 1, 7);
            this.rollTablePanel.Controls.Add(this.rollMinButton7, 0, 7);
            this.rollTablePanel.Controls.Add(this.rollTitleBox9, 6, 6);
            this.rollTablePanel.Controls.Add(this.rollTitleBox8, 3, 6);
            this.rollTablePanel.Controls.Add(this.rollTitleBox7, 0, 6);
            this.rollTablePanel.Controls.Add(this.rollPlusButtion6, 8, 4);
            this.rollTablePanel.Controls.Add(this.rollCountBox6, 7, 4);
            this.rollTablePanel.Controls.Add(this.rollMinButton6, 6, 4);
            this.rollTablePanel.Controls.Add(this.rollPlusButton5, 5, 4);
            this.rollTablePanel.Controls.Add(this.rollCountBox5, 4, 4);
            this.rollTablePanel.Controls.Add(this.rollMinButton5, 3, 4);
            this.rollTablePanel.Controls.Add(this.rollPlusButton4, 2, 4);
            this.rollTablePanel.Controls.Add(this.rollCountBox4, 1, 4);
            this.rollTablePanel.Controls.Add(this.rollMinButton4, 0, 4);
            this.rollTablePanel.Controls.Add(this.rollTitleBox6, 6, 3);
            this.rollTablePanel.Controls.Add(this.rollTitleBox5, 3, 3);
            this.rollTablePanel.Controls.Add(this.rollTitleBox4, 0, 3);
            this.rollTablePanel.Controls.Add(this.rollPlusButton3, 8, 1);
            this.rollTablePanel.Controls.Add(this.rollCountBox3, 7, 1);
            this.rollTablePanel.Controls.Add(this.rollMinButton3, 6, 1);
            this.rollTablePanel.Controls.Add(this.rollPlusButton2, 5, 1);
            this.rollTablePanel.Controls.Add(this.rollCountBox2, 4, 1);
            this.rollTablePanel.Controls.Add(this.rollMinButton2, 3, 1);
            this.rollTablePanel.Controls.Add(this.rollTitleBox3, 6, 0);
            this.rollTablePanel.Controls.Add(this.rollTitleBox2, 3, 0);
            this.rollTablePanel.Controls.Add(this.rollTitleBox1, 0, 0);
            this.rollTablePanel.Controls.Add(this.rollMinButton1, 0, 1);
            this.rollTablePanel.Controls.Add(this.rollPlusButton1, 2, 1);
            this.rollTablePanel.Controls.Add(this.rollCountBox1, 1, 1);
            this.rollTablePanel.Controls.Add(this.rollDiceButton1, 1, 2);
            this.rollTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTablePanel.Location = new System.Drawing.Point(0, 0);
            this.rollTablePanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTablePanel.Name = "rollTablePanel";
            this.rollTablePanel.RowCount = 9;
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82412F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83417F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.64773F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.30682F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22727F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rollTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rollTablePanel.Size = new System.Drawing.Size(1319, 518);
            this.rollTablePanel.TabIndex = 3;
            this.rollTablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rollPlusButton9
            // 
            this.rollPlusButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton9.Location = new System.Drawing.Point(724, 364);
            this.rollPlusButton9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton9.Name = "rollPlusButton9";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton9, 2);
            this.rollPlusButton9.Size = new System.Drawing.Size(715, 151);
            this.rollPlusButton9.TabIndex = 35;
            this.rollPlusButton9.Text = "+";
            this.rollPlusButton9.UseVisualStyleBackColor = true;
            // 
            // rollCountBox9
            // 
            this.rollCountBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox9.Location = new System.Drawing.Point(619, 364);
            this.rollCountBox9.Name = "rollCountBox9";
            this.rollCountBox9.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox9.TabIndex = 34;
            // 
            // rollMinButton9
            // 
            this.rollMinButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton9.Location = new System.Drawing.Point(552, 364);
            this.rollMinButton9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton9.Name = "rollMinButton9";
            this.rollTablePanel.SetRowSpan(this.rollMinButton9, 2);
            this.rollMinButton9.Size = new System.Drawing.Size(62, 151);
            this.rollMinButton9.TabIndex = 33;
            this.rollMinButton9.Text = "-";
            this.rollMinButton9.UseVisualStyleBackColor = true;
            // 
            // rollPlusButton8
            // 
            this.rollPlusButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton8.Location = new System.Drawing.Point(450, 364);
            this.rollPlusButton8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton8.Name = "rollPlusButton8";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton8, 2);
            this.rollPlusButton8.Size = new System.Drawing.Size(98, 151);
            this.rollPlusButton8.TabIndex = 32;
            this.rollPlusButton8.Text = "+";
            this.rollPlusButton8.UseVisualStyleBackColor = true;
            // 
            // rollCountBox8
            // 
            this.rollCountBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox8.Location = new System.Drawing.Point(345, 364);
            this.rollCountBox8.Name = "rollCountBox8";
            this.rollCountBox8.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox8.TabIndex = 31;
            // 
            // rollMinButton8
            // 
            this.rollMinButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton8.Location = new System.Drawing.Point(278, 364);
            this.rollMinButton8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton8.Name = "rollMinButton8";
            this.rollTablePanel.SetRowSpan(this.rollMinButton8, 2);
            this.rollMinButton8.Size = new System.Drawing.Size(62, 151);
            this.rollMinButton8.TabIndex = 30;
            this.rollMinButton8.Text = "-";
            this.rollMinButton8.UseVisualStyleBackColor = true;
            // 
            // rollPlusButtion7
            // 
            this.rollPlusButtion7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButtion7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButtion7.Location = new System.Drawing.Point(172, 364);
            this.rollPlusButtion7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButtion7.Name = "rollPlusButtion7";
            this.rollTablePanel.SetRowSpan(this.rollPlusButtion7, 2);
            this.rollPlusButtion7.Size = new System.Drawing.Size(102, 151);
            this.rollPlusButtion7.TabIndex = 29;
            this.rollPlusButtion7.Text = "+";
            this.rollPlusButtion7.UseVisualStyleBackColor = true;
            // 
            // rollCountBox7
            // 
            this.rollCountBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox7.Location = new System.Drawing.Point(67, 364);
            this.rollCountBox7.Name = "rollCountBox7";
            this.rollCountBox7.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox7.TabIndex = 28;
            // 
            // rollMinButton7
            // 
            this.rollMinButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton7.Location = new System.Drawing.Point(2, 364);
            this.rollMinButton7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton7.Name = "rollMinButton7";
            this.rollTablePanel.SetRowSpan(this.rollMinButton7, 2);
            this.rollMinButton7.Size = new System.Drawing.Size(60, 151);
            this.rollMinButton7.TabIndex = 27;
            this.rollMinButton7.Text = "-";
            this.rollMinButton7.UseVisualStyleBackColor = true;
            // 
            // rollTitleBox9
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox9, 3);
            this.rollTitleBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox9.Location = new System.Drawing.Point(552, 338);
            this.rollTitleBox9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox9.Name = "rollTitleBox9";
            this.rollTitleBox9.Size = new System.Drawing.Size(887, 20);
            this.rollTitleBox9.TabIndex = 26;
            // 
            // rollTitleBox8
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox8, 3);
            this.rollTitleBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox8.Location = new System.Drawing.Point(278, 338);
            this.rollTitleBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox8.Name = "rollTitleBox8";
            this.rollTitleBox8.Size = new System.Drawing.Size(270, 20);
            this.rollTitleBox8.TabIndex = 25;
            // 
            // rollTitleBox7
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox7, 3);
            this.rollTitleBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox7.Location = new System.Drawing.Point(2, 338);
            this.rollTitleBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox7.Name = "rollTitleBox7";
            this.rollTitleBox7.Size = new System.Drawing.Size(272, 20);
            this.rollTitleBox7.TabIndex = 24;
            // 
            // rollPlusButtion6
            // 
            this.rollPlusButtion6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButtion6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButtion6.Location = new System.Drawing.Point(724, 194);
            this.rollPlusButtion6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButtion6.Name = "rollPlusButtion6";
            this.rollTablePanel.SetRowSpan(this.rollPlusButtion6, 2);
            this.rollPlusButtion6.Size = new System.Drawing.Size(715, 138);
            this.rollPlusButtion6.TabIndex = 23;
            this.rollPlusButtion6.Text = "+";
            this.rollPlusButtion6.UseVisualStyleBackColor = true;
            // 
            // rollCountBox6
            // 
            this.rollCountBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox6.Location = new System.Drawing.Point(619, 194);
            this.rollCountBox6.Name = "rollCountBox6";
            this.rollCountBox6.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox6.TabIndex = 22;
            // 
            // rollMinButton6
            // 
            this.rollMinButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton6.Location = new System.Drawing.Point(552, 194);
            this.rollMinButton6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton6.Name = "rollMinButton6";
            this.rollTablePanel.SetRowSpan(this.rollMinButton6, 2);
            this.rollMinButton6.Size = new System.Drawing.Size(62, 138);
            this.rollMinButton6.TabIndex = 21;
            this.rollMinButton6.Text = "-";
            this.rollMinButton6.UseVisualStyleBackColor = true;
            // 
            // rollPlusButton5
            // 
            this.rollPlusButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton5.Location = new System.Drawing.Point(450, 194);
            this.rollPlusButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton5.Name = "rollPlusButton5";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton5, 2);
            this.rollPlusButton5.Size = new System.Drawing.Size(98, 138);
            this.rollPlusButton5.TabIndex = 20;
            this.rollPlusButton5.Text = "+";
            this.rollPlusButton5.UseVisualStyleBackColor = true;
            // 
            // rollCountBox5
            // 
            this.rollCountBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox5.Location = new System.Drawing.Point(345, 194);
            this.rollCountBox5.Name = "rollCountBox5";
            this.rollCountBox5.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox5.TabIndex = 19;
            // 
            // rollMinButton5
            // 
            this.rollMinButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton5.Location = new System.Drawing.Point(278, 194);
            this.rollMinButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton5.Name = "rollMinButton5";
            this.rollTablePanel.SetRowSpan(this.rollMinButton5, 2);
            this.rollMinButton5.Size = new System.Drawing.Size(62, 138);
            this.rollMinButton5.TabIndex = 18;
            this.rollMinButton5.Text = "-";
            this.rollMinButton5.UseVisualStyleBackColor = true;
            // 
            // rollPlusButton4
            // 
            this.rollPlusButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton4.Location = new System.Drawing.Point(172, 194);
            this.rollPlusButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton4.Name = "rollPlusButton4";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton4, 2);
            this.rollPlusButton4.Size = new System.Drawing.Size(102, 138);
            this.rollPlusButton4.TabIndex = 17;
            this.rollPlusButton4.Text = "+";
            this.rollPlusButton4.UseVisualStyleBackColor = true;
            // 
            // rollCountBox4
            // 
            this.rollCountBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox4.Location = new System.Drawing.Point(67, 194);
            this.rollCountBox4.Name = "rollCountBox4";
            this.rollCountBox4.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox4.TabIndex = 16;
            // 
            // rollMinButton4
            // 
            this.rollMinButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton4.Location = new System.Drawing.Point(2, 194);
            this.rollMinButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton4.Name = "rollMinButton4";
            this.rollTablePanel.SetRowSpan(this.rollMinButton4, 2);
            this.rollMinButton4.Size = new System.Drawing.Size(60, 138);
            this.rollMinButton4.TabIndex = 15;
            this.rollMinButton4.Text = "-";
            this.rollMinButton4.UseVisualStyleBackColor = true;
            // 
            // rollTitleBox6
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox6, 3);
            this.rollTitleBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox6.Location = new System.Drawing.Point(552, 168);
            this.rollTitleBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox6.Name = "rollTitleBox6";
            this.rollTitleBox6.Size = new System.Drawing.Size(887, 20);
            this.rollTitleBox6.TabIndex = 14;
            // 
            // rollTitleBox5
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox5, 3);
            this.rollTitleBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox5.Location = new System.Drawing.Point(278, 168);
            this.rollTitleBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox5.Name = "rollTitleBox5";
            this.rollTitleBox5.Size = new System.Drawing.Size(270, 20);
            this.rollTitleBox5.TabIndex = 13;
            // 
            // rollTitleBox4
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox4, 3);
            this.rollTitleBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox4.Location = new System.Drawing.Point(2, 168);
            this.rollTitleBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox4.Name = "rollTitleBox4";
            this.rollTitleBox4.Size = new System.Drawing.Size(272, 20);
            this.rollTitleBox4.TabIndex = 12;
            // 
            // rollPlusButton3
            // 
            this.rollPlusButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton3.Location = new System.Drawing.Point(724, 29);
            this.rollPlusButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton3.Name = "rollPlusButton3";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton3, 2);
            this.rollPlusButton3.Size = new System.Drawing.Size(715, 133);
            this.rollPlusButton3.TabIndex = 11;
            this.rollPlusButton3.Text = "+";
            this.rollPlusButton3.UseVisualStyleBackColor = true;
            // 
            // rollCountBox3
            // 
            this.rollCountBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox3.Location = new System.Drawing.Point(619, 29);
            this.rollCountBox3.Name = "rollCountBox3";
            this.rollCountBox3.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox3.TabIndex = 10;
            // 
            // rollMinButton3
            // 
            this.rollMinButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton3.Location = new System.Drawing.Point(552, 29);
            this.rollMinButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton3.Name = "rollMinButton3";
            this.rollTablePanel.SetRowSpan(this.rollMinButton3, 2);
            this.rollMinButton3.Size = new System.Drawing.Size(62, 133);
            this.rollMinButton3.TabIndex = 9;
            this.rollMinButton3.Text = "-";
            this.rollMinButton3.UseVisualStyleBackColor = true;
            // 
            // rollPlusButton2
            // 
            this.rollPlusButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton2.Location = new System.Drawing.Point(450, 29);
            this.rollPlusButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton2.Name = "rollPlusButton2";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton2, 2);
            this.rollPlusButton2.Size = new System.Drawing.Size(98, 133);
            this.rollPlusButton2.TabIndex = 8;
            this.rollPlusButton2.Text = "+";
            this.rollPlusButton2.UseVisualStyleBackColor = true;
            // 
            // rollCountBox2
            // 
            this.rollCountBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox2.Location = new System.Drawing.Point(345, 29);
            this.rollCountBox2.Name = "rollCountBox2";
            this.rollCountBox2.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox2.TabIndex = 7;
            // 
            // rollMinButton2
            // 
            this.rollMinButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton2.Location = new System.Drawing.Point(278, 29);
            this.rollMinButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton2.Name = "rollMinButton2";
            this.rollTablePanel.SetRowSpan(this.rollMinButton2, 2);
            this.rollMinButton2.Size = new System.Drawing.Size(62, 133);
            this.rollMinButton2.TabIndex = 6;
            this.rollMinButton2.Text = "-";
            this.rollMinButton2.UseVisualStyleBackColor = true;
            // 
            // rollTitleBox3
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox3, 3);
            this.rollTitleBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox3.Location = new System.Drawing.Point(552, 3);
            this.rollTitleBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox3.Name = "rollTitleBox3";
            this.rollTitleBox3.Size = new System.Drawing.Size(887, 20);
            this.rollTitleBox3.TabIndex = 5;
            // 
            // rollTitleBox2
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox2, 3);
            this.rollTitleBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox2.Location = new System.Drawing.Point(278, 3);
            this.rollTitleBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox2.Name = "rollTitleBox2";
            this.rollTitleBox2.Size = new System.Drawing.Size(270, 20);
            this.rollTitleBox2.TabIndex = 4;
            // 
            // rollTitleBox1
            // 
            this.rollTablePanel.SetColumnSpan(this.rollTitleBox1, 3);
            this.rollTitleBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollTitleBox1.Location = new System.Drawing.Point(2, 3);
            this.rollTitleBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollTitleBox1.Name = "rollTitleBox1";
            this.rollTitleBox1.Size = new System.Drawing.Size(272, 20);
            this.rollTitleBox1.TabIndex = 0;
            // 
            // rollMinButton1
            // 
            this.rollMinButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollMinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollMinButton1.Location = new System.Drawing.Point(2, 29);
            this.rollMinButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollMinButton1.Name = "rollMinButton1";
            this.rollTablePanel.SetRowSpan(this.rollMinButton1, 2);
            this.rollMinButton1.Size = new System.Drawing.Size(60, 133);
            this.rollMinButton1.TabIndex = 1;
            this.rollMinButton1.Text = "-";
            this.rollMinButton1.UseVisualStyleBackColor = true;
            // 
            // rollPlusButton1
            // 
            this.rollPlusButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollPlusButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPlusButton1.Location = new System.Drawing.Point(172, 29);
            this.rollPlusButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rollPlusButton1.Name = "rollPlusButton1";
            this.rollTablePanel.SetRowSpan(this.rollPlusButton1, 2);
            this.rollPlusButton1.Size = new System.Drawing.Size(102, 133);
            this.rollPlusButton1.TabIndex = 2;
            this.rollPlusButton1.Text = "+";
            this.rollPlusButton1.UseVisualStyleBackColor = true;
            // 
            // rollCountBox1
            // 
            this.rollCountBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollCountBox1.Location = new System.Drawing.Point(67, 29);
            this.rollCountBox1.Name = "rollCountBox1";
            this.rollCountBox1.Size = new System.Drawing.Size(100, 20);
            this.rollCountBox1.TabIndex = 3;
            // 
            // rollDiceButton1
            // 
            this.rollDiceButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton1.Location = new System.Drawing.Point(67, 94);
            this.rollDiceButton1.Name = "rollDiceButton1";
            this.rollDiceButton1.Size = new System.Drawing.Size(100, 68);
            this.rollDiceButton1.TabIndex = 36;
            this.rollDiceButton1.Text = "RollDice";
            this.rollDiceButton1.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton2
            // 
            this.rollDiceButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton2.Location = new System.Drawing.Point(345, 94);
            this.rollDiceButton2.Name = "rollDiceButton2";
            this.rollDiceButton2.Size = new System.Drawing.Size(100, 68);
            this.rollDiceButton2.TabIndex = 37;
            this.rollDiceButton2.Text = "RollDice";
            this.rollDiceButton2.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton3
            // 
            this.rollDiceButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton3.Location = new System.Drawing.Point(619, 94);
            this.rollDiceButton3.Name = "rollDiceButton3";
            this.rollDiceButton3.Size = new System.Drawing.Size(100, 68);
            this.rollDiceButton3.TabIndex = 38;
            this.rollDiceButton3.Text = "RollDice";
            this.rollDiceButton3.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton4
            // 
            this.rollDiceButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton4.Location = new System.Drawing.Point(67, 245);
            this.rollDiceButton4.Name = "rollDiceButton4";
            this.rollDiceButton4.Size = new System.Drawing.Size(100, 87);
            this.rollDiceButton4.TabIndex = 39;
            this.rollDiceButton4.Text = "RollDice";
            this.rollDiceButton4.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton5
            // 
            this.rollDiceButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton5.Location = new System.Drawing.Point(345, 245);
            this.rollDiceButton5.Name = "rollDiceButton5";
            this.rollDiceButton5.Size = new System.Drawing.Size(100, 87);
            this.rollDiceButton5.TabIndex = 40;
            this.rollDiceButton5.Text = "RollDice";
            this.rollDiceButton5.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton6
            // 
            this.rollDiceButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton6.Location = new System.Drawing.Point(619, 245);
            this.rollDiceButton6.Name = "rollDiceButton6";
            this.rollDiceButton6.Size = new System.Drawing.Size(100, 87);
            this.rollDiceButton6.TabIndex = 41;
            this.rollDiceButton6.Text = "RollDice";
            this.rollDiceButton6.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton7
            // 
            this.rollDiceButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton7.Location = new System.Drawing.Point(67, 409);
            this.rollDiceButton7.Name = "rollDiceButton7";
            this.rollDiceButton7.Size = new System.Drawing.Size(100, 106);
            this.rollDiceButton7.TabIndex = 42;
            this.rollDiceButton7.Text = "RollDice";
            this.rollDiceButton7.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton8
            // 
            this.rollDiceButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton8.Location = new System.Drawing.Point(345, 409);
            this.rollDiceButton8.Name = "rollDiceButton8";
            this.rollDiceButton8.Size = new System.Drawing.Size(100, 106);
            this.rollDiceButton8.TabIndex = 43;
            this.rollDiceButton8.Text = "RollDice";
            this.rollDiceButton8.UseVisualStyleBackColor = true;
            // 
            // rollDiceButton9
            // 
            this.rollDiceButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton9.Location = new System.Drawing.Point(619, 409);
            this.rollDiceButton9.Name = "rollDiceButton9";
            this.rollDiceButton9.Size = new System.Drawing.Size(100, 106);
            this.rollDiceButton9.TabIndex = 44;
            this.rollDiceButton9.Text = "RollDice";
            this.rollDiceButton9.UseVisualStyleBackColor = true;
            // 
            // DiceRollerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 884);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DiceRollerUserControl";
            this.Text = "Form1";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            this.rollTablePanel.ResumeLayout(false);
            this.rollTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView historyView;
        private System.Windows.Forms.ColumnHeader columnHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.Button rollPlusButton9;
        private System.Windows.Forms.TextBox rollCountBox9;
        private System.Windows.Forms.Button rollMinButton9;
        private System.Windows.Forms.Button rollPlusButton8;
        private System.Windows.Forms.TextBox rollCountBox8;
        private System.Windows.Forms.Button rollMinButton8;
        private System.Windows.Forms.Button rollPlusButtion7;
        private System.Windows.Forms.TextBox rollCountBox7;
        private System.Windows.Forms.Button rollMinButton7;
        private System.Windows.Forms.TextBox rollTitleBox9;
        private System.Windows.Forms.TextBox rollTitleBox8;
        private System.Windows.Forms.TextBox rollTitleBox7;
        private System.Windows.Forms.Button rollPlusButtion6;
        private System.Windows.Forms.TextBox rollCountBox6;
        private System.Windows.Forms.Button rollMinButton6;
        private System.Windows.Forms.Button rollPlusButton5;
        private System.Windows.Forms.TextBox rollCountBox5;
        private System.Windows.Forms.Button rollMinButton5;
        private System.Windows.Forms.Button rollPlusButton4;
        private System.Windows.Forms.TextBox rollCountBox4;
        private System.Windows.Forms.Button rollMinButton4;
        private System.Windows.Forms.TextBox rollTitleBox6;
        private System.Windows.Forms.TextBox rollTitleBox5;
        private System.Windows.Forms.TextBox rollTitleBox4;
        private System.Windows.Forms.Button rollPlusButton3;
        private System.Windows.Forms.TextBox rollCountBox3;
        private System.Windows.Forms.Button rollMinButton3;
        private System.Windows.Forms.Button rollPlusButton2;
        private System.Windows.Forms.TextBox rollCountBox2;
        private System.Windows.Forms.Button rollMinButton2;
        private System.Windows.Forms.TextBox rollTitleBox3;
        private System.Windows.Forms.TextBox rollTitleBox2;
        private System.Windows.Forms.TextBox rollTitleBox1;
        private System.Windows.Forms.Button rollMinButton1;
        private System.Windows.Forms.Button rollPlusButton1;
        private System.Windows.Forms.TextBox rollCountBox1;
        private System.Windows.Forms.Button rollDiceButton1;
        private System.Windows.Forms.TableLayoutPanel rollTablePanel;
        private System.Windows.Forms.Button rollDiceButton9;
        private System.Windows.Forms.Button rollDiceButton8;
        private System.Windows.Forms.Button rollDiceButton7;
        private System.Windows.Forms.Button rollDiceButton6;
        private System.Windows.Forms.Button rollDiceButton5;
        private System.Windows.Forms.Button rollDiceButton4;
        private System.Windows.Forms.Button rollDiceButton3;
        private System.Windows.Forms.Button rollDiceButton2;
    }
}

