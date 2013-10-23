using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowRunDiceRoller
{
    public partial class DiceRollerUserForm : Form
    {
        private Dice _diceRoll = new Dice();
        private Roll _currentRoll = new Roll();
        private int _rollNumber = 1;
        private int _currentNumDice = 1;

        public DiceRollerUserForm()
        {
            InitializeComponent();
        }

        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            _currentRoll = _diceRoll.RollTheDice(_currentNumDice, false, false);
            var i = new ListViewItem(_rollNumber.ToString());
            i.SubItems.Add(_currentRoll.numHits.ToString());
            i.SubItems.Add(_currentRoll.rawRoll);
            i.SubItems.Add(_currentRoll.isGlitch.ToString());
            i.SubItems.Add(_currentRoll.isCritGlitch.ToString());
            resultView.Items.Add(i);
            _rollNumber++;
        }

        private void RollDiceWithEdgeButton_Click(object sender, EventArgs e)
        {
            //woo this totally does the same thing as a normal roll right now
            //this wneeds to re roll the dice from the previous roll in particular any dice that were not a hit(5 or 6)
            _currentRoll = _diceRoll.RollTheDice(_currentNumDice, false, false);
            var i = new ListViewItem(_rollNumber.ToString());
            i.SubItems.Add(_currentRoll.numHits.ToString());
            i.SubItems.Add(_currentRoll.rawRoll);
            i.SubItems.Add(_currentRoll.isGlitch.ToString());
            i.SubItems.Add(_currentRoll.isCritGlitch.ToString());
            resultView.Items.Add(i);
            _rollNumber++;
        }

        private void reRollDiceWithEdgeButton_Click(object sender, EventArgs e)
        {
            //woo this totally does the same thing as a normal roll right now
            //need to think how to do this this is a normal dice roll with exploding sixes
            //roll the set of dice then roll any sixes again untill no more sixes left.
            //totall all of the 5's and 6's from all the rolls to get your hits
            _currentRoll = _diceRoll.RollTheDice(_currentNumDice, false, false);
            var i = new ListViewItem(_rollNumber.ToString());
            i.SubItems.Add(_currentRoll.numHits.ToString());
            i.SubItems.Add(_currentRoll.rawRoll);
            i.SubItems.Add(_currentRoll.isGlitch.ToString());
            i.SubItems.Add(_currentRoll.isCritGlitch.ToString());
            resultView.Items.Add(i);
            _rollNumber++;
        }

        private void currentNumDiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void numberOfDiceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _currentNumDice = Convert.ToInt32(numberOfDiceNumericUpDown.Value);
        }
    }
}
