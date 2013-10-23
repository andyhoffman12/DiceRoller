namespace ShadowRunDiceRoller
{
    partial class DiceRollerUserForm
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
            this.RollTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.reRollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.rollDiceWithEdgeButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.numberOfDiceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentNumDiceLabel = new System.Windows.Forms.Label();
            this.resultView = new System.Windows.Forms.ListView();
            this.RollHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HitsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GlitchHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CriticalGlitchHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiceNumericUpDown)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RollTypeHeader
            // 
            this.RollTypeHeader.Text = "NotImplementedRoletypeheader";
            this.RollTypeHeader.Width = 93;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.reRollDiceWithEdgeButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.rollDiceWithEdgeButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.rollDiceButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.numberOfDiceNumericUpDown);
            this.mainSplitContainer.Panel1.Controls.Add(this.currentNumDiceLabel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.resultView);
            this.mainSplitContainer.Size = new System.Drawing.Size(1338, 607);
            this.mainSplitContainer.SplitterDistance = 499;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // reRollDiceWithEdgeButton
            // 
            this.reRollDiceWithEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reRollDiceWithEdgeButton.Location = new System.Drawing.Point(296, 528);
            this.reRollDiceWithEdgeButton.Name = "reRollDiceWithEdgeButton";
            this.reRollDiceWithEdgeButton.Size = new System.Drawing.Size(117, 65);
            this.reRollDiceWithEdgeButton.TabIndex = 4;
            this.reRollDiceWithEdgeButton.Text = "ReRoll W/ Edge";
            this.reRollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            this.reRollDiceWithEdgeButton.Click += new System.EventHandler(this.reRollDiceWithEdgeButton_Click);
            // 
            // rollDiceWithEdgeButton
            // 
            this.rollDiceWithEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceWithEdgeButton.Location = new System.Drawing.Point(173, 528);
            this.rollDiceWithEdgeButton.Name = "rollDiceWithEdgeButton";
            this.rollDiceWithEdgeButton.Size = new System.Drawing.Size(117, 65);
            this.rollDiceWithEdgeButton.TabIndex = 3;
            this.rollDiceWithEdgeButton.Text = "Roll W/ Edge";
            this.rollDiceWithEdgeButton.UseVisualStyleBackColor = true;
            this.rollDiceWithEdgeButton.Click += new System.EventHandler(this.RollDiceWithEdgeButton_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.Location = new System.Drawing.Point(10, 528);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(157, 65);
            this.rollDiceButton.TabIndex = 2;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.RollDiceButton_Click);
            // 
            // numberOfDiceNumericUpDown
            // 
            this.numberOfDiceNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfDiceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiceNumericUpDown.Location = new System.Drawing.Point(263, 490);
            this.numberOfDiceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDiceNumericUpDown.Name = "numberOfDiceNumericUpDown";
            this.numberOfDiceNumericUpDown.Size = new System.Drawing.Size(150, 32);
            this.numberOfDiceNumericUpDown.TabIndex = 5;
            this.numberOfDiceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDiceNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfDiceNumericUpDown_ValueChanged);
            // 
            // currentNumDiceLabel
            // 
            this.currentNumDiceLabel.AutoSize = true;
            this.currentNumDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNumDiceLabel.Location = new System.Drawing.Point(10, 490);
            this.currentNumDiceLabel.Name = "currentNumDiceLabel";
            this.currentNumDiceLabel.Size = new System.Drawing.Size(247, 26);
            this.currentNumDiceLabel.TabIndex = 6;
            this.currentNumDiceLabel.Text = "Current Number Of Dice";
            this.currentNumDiceLabel.Click += new System.EventHandler(this.currentNumDiceLabel_Click);
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
            this.resultView.Size = new System.Drawing.Size(833, 603);
            this.resultView.TabIndex = 0;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
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
            this.ResultsHeader.Width = 512;
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
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.MenuStrip.Size = new System.Drawing.Size(1338, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.Visible = false;
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
            // 
            // DiceRollerUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 607);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DiceRollerUserForm";
            this.Text = "ShadowRunDiceRoller";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiceNumericUpDown)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView resultView;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader RollHeader;
        private System.Windows.Forms.ColumnHeader HitsHeader;
        private System.Windows.Forms.ColumnHeader ResultsHeader;
        private System.Windows.Forms.ColumnHeader GlitchHeader;
        private System.Windows.Forms.ColumnHeader CriticalGlitchHeader;
        private System.Windows.Forms.ColumnHeader RollTypeHeader;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Button reRollDiceWithEdgeButton;
        private System.Windows.Forms.Button rollDiceWithEdgeButton;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.NumericUpDown numberOfDiceNumericUpDown;
        private System.Windows.Forms.Label currentNumDiceLabel;
    }
}

