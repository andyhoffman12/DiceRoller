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
        private Dice _diceRoll = new Dice();
        private Roll _currentRoll = new Roll();
        private int _rollNumber = 1;
        private int _currentNumDice = 1;

        public DiceRollerUserControl()
        {
            InitializeComponent();
        }

        private void diceToRollBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(diceToRollBox.Text, out _currentNumDice))
            {
                _currentNumDice = int.Parse(diceToRollBox.Text);
            }
            else
            {
                _currentNumDice = 1;
            }
            diceToRollBox.Text = _currentNumDice.ToString();
        }

        private void subtractDiceButton_Click(object sender, EventArgs e)
        {
            if (_currentNumDice > 1)
            {
                _currentNumDice--;
            }
            diceToRollBox.Text = _currentNumDice.ToString();
        }

        private void addDiceButton_Click(object sender, EventArgs e)
        {
            if (_currentNumDice < 100)
            {
                _currentNumDice++;
            }
            diceToRollBox.Text = _currentNumDice.ToString();
        }

        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            _currentRoll = _diceRoll.RollTheDice(_currentNumDice, false, false);
            ListViewItem i = new ListViewItem(_rollNumber.ToString());
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
            ListViewItem i = new ListViewItem(_rollNumber.ToString());
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
            ListViewItem i = new ListViewItem(_rollNumber.ToString());
            i.SubItems.Add(_currentRoll.numHits.ToString());
            i.SubItems.Add(_currentRoll.rawRoll);
            i.SubItems.Add(_currentRoll.isGlitch.ToString());
            i.SubItems.Add(_currentRoll.isCritGlitch.ToString());
            resultView.Items.Add(i);
            _rollNumber++;
        }
    }
}
