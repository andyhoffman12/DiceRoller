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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numDiceToRollLabel = new System.Windows.Forms.Label();
            this.diceToRollBox = new System.Windows.Forms.TextBox();
            this.RollDiceButton = new System.Windows.Forms.Button();
            this.RollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.reRollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.subtractDiceButton = new System.Windows.Forms.Button();
            this.addDiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel2.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.mainSplitContainer.SplitterDistance = 1028;
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
            this.historyView.Size = new System.Drawing.Size(589, 856);
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
            // leftSplitContainer.Panel2
            // 
            this.leftSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.leftSplitContainer.Size = new System.Drawing.Size(1028, 860);
            this.leftSplitContainer.SplitterDistance = 415;
            this.leftSplitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.addDiceButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numDiceToRollLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.diceToRollBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RollDiceButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RollDiceWithEdgeButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.reRollDiceWithEdgeButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.subtractDiceButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numDiceToRollLabel
            // 
            this.numDiceToRollLabel.AutoSize = true;
            this.numDiceToRollLabel.Location = new System.Drawing.Point(3, 0);
            this.numDiceToRollLabel.Name = "numDiceToRollLabel";
            this.numDiceToRollLabel.Size = new System.Drawing.Size(162, 24);
            this.numDiceToRollLabel.TabIndex = 0;
            this.numDiceToRollLabel.Text = "Number of Dice:";
            // 
            // diceToRollBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.diceToRollBox, 3);
            this.diceToRollBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diceToRollBox.Location = new System.Drawing.Point(3, 90);
            this.diceToRollBox.Name = "diceToRollBox";
            this.diceToRollBox.Size = new System.Drawing.Size(606, 29);
            this.diceToRollBox.TabIndex = 1;
            // 
            // RollDiceButton
            // 
            this.RollDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollDiceButton.Location = new System.Drawing.Point(3, 177);
            this.RollDiceButton.Name = "RollDiceButton";
            this.RollDiceButton.Size = new System.Drawing.Size(198, 81);
            this.RollDiceButton.TabIndex = 2;
            this.RollDiceButton.Text = "roll";
            this.RollDiceButton.UseVisualStyleBackColor = true;
            // 
            // RollDiceWithEdgeButton
            // 
            this.RollDiceWithEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollDiceWithEdgeButton.Location = new System.Drawing.Point(207, 177);
            this.RollDiceWithEdgeButton.Name = "RollDiceWithEdgeButton";
            this.RollDiceWithEdgeButton.Size = new System.Drawing.Size(198, 81);
            this.RollDiceWithEdgeButton.TabIndex = 3;
            this.RollDiceWithEdgeButton.Text = "roll with edge";
            this.RollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            // 
            // reRollDiceWithEdgeButton
            // 
            this.reRollDiceWithEdgeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reRollDiceWithEdgeButton.Location = new System.Drawing.Point(411, 177);
            this.reRollDiceWithEdgeButton.Name = "reRollDiceWithEdgeButton";
            this.reRollDiceWithEdgeButton.Size = new System.Drawing.Size(198, 81);
            this.reRollDiceWithEdgeButton.TabIndex = 4;
            this.reRollDiceWithEdgeButton.Text = "reroll with edge";
            this.reRollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            // 
            // subtractDiceButton
            // 
            this.subtractDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractDiceButton.Location = new System.Drawing.Point(207, 3);
            this.subtractDiceButton.Name = "subtractDiceButton";
            this.subtractDiceButton.Size = new System.Drawing.Size(198, 81);
            this.subtractDiceButton.TabIndex = 5;
            this.subtractDiceButton.Text = "-";
            this.subtractDiceButton.UseVisualStyleBackColor = true;
            // 
            // addDiceButton
            // 
            this.addDiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiceButton.Location = new System.Drawing.Point(411, 3);
            this.addDiceButton.Name = "addDiceButton";
            this.addDiceButton.Size = new System.Drawing.Size(198, 81);
            this.addDiceButton.TabIndex = 6;
            this.addDiceButton.Text = "+";
            this.addDiceButton.UseVisualStyleBackColor = true;
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
            this.leftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addDiceButton;
        private System.Windows.Forms.Label numDiceToRollLabel;
        private System.Windows.Forms.TextBox diceToRollBox;
        private System.Windows.Forms.Button RollDiceButton;
        private System.Windows.Forms.Button RollDiceWithEdgeButton;
        private System.Windows.Forms.Button reRollDiceWithEdgeButton;
        private System.Windows.Forms.Button subtractDiceButton;
    }
}

