using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DiceRollerWinForms
{
    class Roll
    {
        public string rawRoll { get; set; }
        public int numHits {get; set;}
        public bool isGlitch {get; set;}
        public bool isCritGlitch{get; set;}
        public int lastNumDiceRolled { get; set; }
        public int lastNumHitsRolled { get; set; }
        public bool lastRollWasEdge { get; set; }
        

        internal void FinalRollResults(int[] resultsRaw, int numDice)
        {
            var rollResults = new int[6];

            for (var i = 0; i < numDice; i++)
            {
                //is this legit?
                switch(resultsRaw[i])
                {
                    case 1:
                        rollResults[0]++;
                        break;
                    case 2:
                        rollResults[1]++;
                        break;
                    case 3:
                        rollResults[2]++;
                        break;
                    case 4:
                        rollResults[3]++;
                        break;
                    case 5:
                        rollResults[4]++;
                        break;
                    case 6:
                        rollResults[5]++;
                        break;
                }
            }

            numHits = rollResults[4] + rollResults[5]; //hits are the number of dice that rolld a 5 or 6
            //If more than half the dice you rolled show a one, then you’ve got problems. 
            //This is called a glitch.
            if ((numDice / 2) < rollResults[0])
            {
                this.isGlitch = true;
                    
                if (numHits == 0)
                {
                    this.isCritGlitch = true;
                }
            }

            rawRoll = string.Join(",", resultsRaw);

        }
        public Roll()
        {
             //six the number of sides on a dice
            rawRoll = ""; //its a magic number
            numHits = 0;
            isGlitch = false;
            isCritGlitch = false;
        }
    }
    class Dice : Roll
    {
        private int const_Delay = 0;

        private RNGCryptoServiceProvider RNGProvider = new RNGCryptoServiceProvider();

        public Roll RollTheDice(int numberOfDiceToRoll, bool edgeRoll, bool reRollEdge)
        {
            var currentRoll = new Roll();
            var results = new int[numberOfDiceToRoll];



            for (var i = 0; i < numberOfDiceToRoll; i++)
            {
                System.Threading.Thread.Sleep(const_Delay);
                results[i] = RNGDiceRoll(RNGProvider);
            }

            currentRoll.FinalRollResults(results, numberOfDiceToRoll);
            currentRoll.lastNumDiceRolled = numberOfDiceToRoll;
            currentRoll.lastNumHitsRolled = currentRoll.numHits; 
            if (edgeRoll) 
            {
                lastRollWasEdge = true;
            }

            return currentRoll;
        }
        private int RNGDiceRoll(RNGCryptoServiceProvider Provider)
        {
            byte[] arr = new byte[4];
            int rand = 0;
            while (rand < 1)
            {
                Provider.GetBytes(arr);
                rand = BitConverter.ToInt32(arr, 0);
            }
            int roll = (rand % 6) + 1;
            return roll;
        }
    }
}
