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
            this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addDiceButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.rollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.reRollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.subtractDiceButton = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.ListView();
            this.RollHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HitsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GlitchHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CriticalGlitchHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RollTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numDiceToRollLabel = new System.Windows.Forms.Label();
            this.diceToRollBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel2.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.mainSplitContainer.Panel2.Controls.Add(this.resultView);
            this.mainSplitContainer.Size = new System.Drawing.Size(1338, 583);
            this.mainSplitContainer.SplitterDistance = 500;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
            // 
            // leftSplitContainer
            // 
            this.leftSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.leftSplitContainer.Name = "leftSplitContainer";
            this.leftSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftSplitContainer.Panel2
            // 
            this.leftSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.leftSplitContainer.Size = new System.Drawing.Size(500, 583);
            this.leftSplitContainer.SplitterDistance = 440;
            this.leftSplitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.addDiceButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rollDiceButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rollDiceWithEdgeButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reRollDiceWithEdgeButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.subtractDiceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addDiceButton
            // 
            this.addDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiceButton.Location = new System.Drawing.Point(333, 3);
            this.addDiceButton.Name = "addDiceButton";
            this.addDiceButton.Size = new System.Drawing.Size(160, 61);
            this.addDiceButton.TabIndex = 6;
            this.addDiceButton.Text = "+";
            this.addDiceButton.UseVisualStyleBackColor = true;
            this.addDiceButton.Click += new System.EventHandler(this.addDiceButton_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceButton.Location = new System.Drawing.Point(3, 70);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(159, 62);
            this.rollDiceButton.TabIndex = 2;
            this.rollDiceButton.Text = "roll";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.RollDiceButton_Click);
            // 
            // rollDiceWithEdgeButton
            // 
            this.rollDiceWithEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollDiceWithEdgeButton.Location = new System.Drawing.Point(168, 70);
            this.rollDiceWithEdgeButton.Name = "rollDiceWithEdgeButton";
            this.rollDiceWithEdgeButton.Size = new System.Drawing.Size(159, 62);
            this.rollDiceWithEdgeButton.TabIndex = 3;
            this.rollDiceWithEdgeButton.Text = "roll with edge";
            this.rollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            this.rollDiceWithEdgeButton.Click += new System.EventHandler(this.RollDiceWithEdgeButton_Click);
            // 
            // reRollDiceWithEdgeButton
            // 
            this.reRollDiceWithEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reRollDiceWithEdgeButton.Location = new System.Drawing.Point(333, 70);
            this.reRollDiceWithEdgeButton.Name = "reRollDiceWithEdgeButton";
            this.reRollDiceWithEdgeButton.Size = new System.Drawing.Size(160, 62);
            this.reRollDiceWithEdgeButton.TabIndex = 4;
            this.reRollDiceWithEdgeButton.Text = "reroll with edge";
            this.reRollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            this.reRollDiceWithEdgeButton.Click += new System.EventHandler(this.reRollDiceWithEdgeButton_Click);
            // 
            // subtractDiceButton
            // 
            this.subtractDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractDiceButton.Location = new System.Drawing.Point(3, 3);
            this.subtractDiceButton.Name = "subtractDiceButton";
            this.subtractDiceButton.Size = new System.Drawing.Size(159, 61);
            this.subtractDiceButton.TabIndex = 5;
            this.subtractDiceButton.Text = "-";
            this.subtractDiceButton.UseVisualStyleBackColor = true;
            this.subtractDiceButton.Click += new System.EventHandler(this.subtractDiceButton_Click);
            // 
            // resultView
            // 
            this.resultView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RollHeader,
            this.HitsHeader,
            this.ResultsHeader,
            this.GlitchHeader,
            this.CriticalGlitchHeader,
            this.RollTypeHeader});
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.HoverSelection = true;
            this.resultView.Location = new System.Drawing.Point(0, 0);
            this.resultView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(832, 579);
            this.resultView.TabIndex = 0;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
            this.resultView.SelectedIndexChanged += new System.EventHandler(this.resultView_SelectedIndexChanged);
            // 
            // RollHeader
            // 
            this.RollHeader.Text = "Roll";
            this.RollHeader.Width = 40;
            // 
            // HitsHeader
            // 
            this.HitsHeader.Text = "Hits";
            this.HitsHeader.Width = 40;
            // 
            // ResultsHeader
            // 
            this.ResultsHeader.Text = "Results";
            this.ResultsHeader.Width = 256;
            // 
            // GlitchHeader
            // 
            this.GlitchHeader.Text = "Glitch";
            this.GlitchHeader.Width = 40;
            // 
            // CriticalGlitchHeader
            // 
            this.CriticalGlitchHeader.Text = "Critical Glitch";
            this.CriticalGlitchHeader.Width = 80;
            // 
            // RollTypeHeader
            // 
            this.RollTypeHeader.Text = "NotImplemented";
            this.RollTypeHeader.Width = 93;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "Save";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(168, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numDiceToRollLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.diceToRollBox);
            this.splitContainer1.Size = new System.Drawing.Size(159, 61);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 7;
            // 
            // numDiceToRollLabel
            // 
            this.numDiceToRollLabel.AutoSize = true;
            this.numDiceToRollLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDiceToRollLabel.Location = new System.Drawing.Point(0, 0);
            this.numDiceToRollLabel.Name = "numDiceToRollLabel";
            this.numDiceToRollLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numDiceToRollLabel.Size = new System.Drawing.Size(162, 24);
            this.numDiceToRollLabel.TabIndex = 1;
            this.numDiceToRollLabel.Text = "Number of Dice:";
            this.numDiceToRollLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // diceToRollBox
            // 
            this.diceToRollBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diceToRollBox.Location = new System.Drawing.Point(0, 0);
            this.diceToRollBox.Name = "diceToRollBox";
            this.diceToRollBox.Size = new System.Drawing.Size(159, 29);
            this.diceToRollBox.TabIndex = 2;
            // 
            // DiceRollerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 607);
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
            this.leftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView resultView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addDiceButton;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Button rollDiceWithEdgeButton;
        private System.Windows.Forms.Button reRollDiceWithEdgeButton;
        private System.Windows.Forms.Button subtractDiceButton;
        private System.Windows.Forms.ColumnHeader RollHeader;
        private System.Windows.Forms.ColumnHeader HitsHeader;
        private System.Windows.Forms.ColumnHeader ResultsHeader;
        private System.Windows.Forms.ColumnHeader GlitchHeader;
        private System.Windows.Forms.ColumnHeader CriticalGlitchHeader;
        private System.Windows.Forms.ColumnHeader RollTypeHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label numDiceToRollLabel;
        public System.Windows.Forms.TextBox diceToRollBox;

        public string numDiceToRollLabel_Text
        {
            get
            {
                return this.numDiceToRollLabel.Text;
            }
            set
            {
                numDiceToRollLabel.Text = value;
            }
        }
    }
}

