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
        public Int32 numHits {get; set;}
        public bool isGlitch {get; set;}
        public bool isCritGlitch{get; set;}
        public Int32 lastNumDiceRolled { get; set; }
        public Int32 lastNumHitsRolled { get; set; }
        public bool lastRollWasEdge { get; set; }

        internal void FinalRollResults(Int32[] resultsRaw, Int32 numDice)
        {
            Int32[] rollResults = new Int32[6];

            for (Int32 i = 0; i < numDice; i++)
            {
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

            numHits = rollResults[4] + rollResults[5];
            //If more than half the dice you rolled show a one, then you’ve got problems. This is called a glitch.
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
    class RollDice : Roll
    {
        private RNGCryptoServiceProvider RNGProvider = new RNGCryptoServiceProvider();

        public Roll RollTheDice(Int32 numberOfDiceToRoll, bool edgeRoll, bool reRollEdge)
        {
            Roll currentRoll = new Roll();
            Int32[] results = new Int32[numberOfDiceToRoll];



            for (int i = 0; i < numberOfDiceToRoll; i++)
            {
                System.Threading.Thread.Sleep(16);
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
        private Int32 RNGDiceRoll(RNGCryptoServiceProvider Provider)
        {
            byte[] arr = new byte[4];
            Int32 rand = 0;
            do
            {
                Provider.GetBytes(arr);
                rand = BitConverter.ToInt32(arr, 0);
            }
            while (rand < 1);
            Int32 roll = (rand % 6) + 1;
            return roll;
        }
    }
}
