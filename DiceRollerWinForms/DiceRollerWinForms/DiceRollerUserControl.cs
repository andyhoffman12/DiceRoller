using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerWinForms
{
    public partial class DiceRollerUserControl : Form
    {
        private RollDice diceRoll = new RollDice();
        private Roll currentRoll = new Roll();
        private Int32 rollNumber = 1;
        private Int32 currentNumDice = 0;

        public DiceRollerUserControl()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diceToRollBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(diceToRollBox.Text, out currentNumDice))
            {
                currentNumDice = Int32.Parse(diceToRollBox.Text);
            }
            else
            {
                currentNumDice = 0;
            }
            diceToRollBox.Text = currentNumDice.ToString();
        }

        private void subtractDiceButton_Click(object sender, EventArgs e)
        {
            currentNumDice--;
            diceToRollBox.TextChanged();
        }

        private void addDiceButton_Click(object sender, EventArgs e)
        {
            currentNumDice++;
            diceToRollBox.Refresh();
        }

        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            currentRoll = diceRoll.RollTheDice(currentNumDice);
            ListViewItem i = new ListViewItem(rollNumber.ToString());
            i.SubItems.Add(currentRoll.numHits.ToString());
            i.SubItems.Add(currentRoll.rawRoll);
            i.SubItems.Add(currentRoll.isGlitch.ToString());
            i.SubItems.Add(currentRoll.isCritGlitch.ToString());
            resultView.Items.Add(i);
            rollNumber++;
        }

        private void RollDiceWithEdgeButton_Click(object sender, EventArgs e)
        {
            //magic code needed...
        }

        private void reRollDiceWithEdgeButton_Click(object sender, EventArgs e)
        {
            //even more magic needed
        }

        private void numDiceToRollLabel_Click(object sender, EventArgs e)
        {

        }

        private void resultView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
