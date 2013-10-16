using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using NPack;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            const Int32 NUMBEROFRANDOMSTOTEST = 100000000;
            Int32[] randomValueCountArray_Csharp = new Int32[7];
            Int32[] randomValueCountArray_MersenneTwister = new Int32[7];
            Int32[] randomValueCountArray_RNG = new Int32[7];

            Int32[] runCountPerDice_Csharp = new Int32[10];
            Int32[] runCountLength_Csharp = new Int32[10];

            Int32[] runCountPerDice_MersenneTwister = new Int32[10];
            Int32[] runCountLength_MersenneTwister = new Int32[10];

            Int32[] runCountPerDice_RNG = new Int32[10];
            Int32[] runCountLength_RNG = new Int32[10];

            Int32 lastCsharpRandom = 0;
            Int32 lastCsharpRandomLength = 0;
            Int32 lastMersRandom = 0;
            Int32 lastMersRandomLength = 0;
            Int32 lastRNGRandom = 0;
            Int32 lastRNGRandomLength = 0;
            
            for (int i = 0; i < NUMBEROFRANDOMSTOTEST; i++)
            {
                //random wait interval
                Random waitInterval = new Random();


                //System.Threading.Thread.Sleep(waitInterval.Next(10,100));
                Random cSharpRandom = new Random();
                MersenneTwister mers = new MersenneTwister();
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                Int32 cSharpRandomValue = cSharpRandom.Next(1, 7);
                Int32 mersenneRandomValue = mers.Next(1, 7);
                Int32 RNGRandomValue = RNGDiceRoll(rng);



                TrackNumbers(cSharpRandomValue, randomValueCountArray_Csharp);
                TrackNumbers(mersenneRandomValue, randomValueCountArray_MersenneTwister);
                TrackNumbers(RNGRandomValue, randomValueCountArray_RNG);

                //Console.WriteLine("Csharp: " + cSharpRandomValue + " Mersenne: " + mersenneRandomValue + " RNG: " + RNGRandomValue);

                UpdateRunData(ref runCountPerDice_Csharp, ref runCountLength_Csharp, ref lastCsharpRandom, ref lastCsharpRandomLength, cSharpRandomValue);
                UpdateRunData(ref runCountPerDice_MersenneTwister, ref runCountLength_MersenneTwister, ref lastMersRandom, ref lastMersRandomLength, mersenneRandomValue);
                UpdateRunData(ref runCountPerDice_RNG, ref runCountLength_RNG, ref lastRNGRandom, ref lastRNGRandomLength, RNGRandomValue);
            }

            Console.WriteLine(" ");
            ReportRandomCount("Csharp", randomValueCountArray_Csharp);
            ReportRandomRuns("csharp", runCountPerDice_Csharp);
            ReportRandomRunLengths("cSharp", runCountLength_Csharp);
            Console.WriteLine(" ");
            ReportRandomCount("Mersenne", randomValueCountArray_MersenneTwister);
            ReportRandomRuns("Mersenne", runCountPerDice_MersenneTwister);
            ReportRandomRunLengths("Mersenne", runCountLength_MersenneTwister);
            Console.WriteLine(" ");
            ReportRandomCount("RNG", randomValueCountArray_RNG);
            ReportRandomRuns("RNG", runCountPerDice_RNG);
            ReportRandomRunLengths("RNG", runCountLength_RNG);

            Console.WriteLine("press a key to quit");
            Console.ReadKey();
        }

        private static void ReportRandomRunLengths(string name, int[] RandomRunLength)
        {
            Console.WriteLine(name + " run lengths");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("number " + i + " total " + RandomRunLength[i]);
            }
        }

        private static void ReportRandomRuns(string name, int[] runsList)
        {
            Console.WriteLine("results of " + name + " runs");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("number " + i + " total " + runsList[i]);
            }
        }

        private static void ReportRandomCount(string name, int[] RandomArrayValues)
        {
            Console.WriteLine("Results of " + name + " Random");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("number " + i + " total " + RandomArrayValues[i]);
            }
        }

        private static void UpdateRunData(ref Int32[] checkRandomRun, ref Int32[] checkRandomRunLength, ref Int32 lastRandomValue, ref Int32 lastRandomLength, Int32 CurrentRandomValue)
        {
            if (CurrentRandomValue == lastRandomValue)
            {
                checkRandomRun[CurrentRandomValue]++;
                lastRandomLength++;
                lastRandomValue = CurrentRandomValue;
            }
            else
            {
                checkRandomRunLength[lastRandomValue] = lastRandomLength;
                lastRandomLength = 1;
                lastRandomValue = CurrentRandomValue;
            }
        }

        static void TrackNumbers(Int32 rand, Int32[] arrayToUpdate)
        {
            switch (rand)
            {
                case 1:
                    arrayToUpdate[1]++;
                    break;
                case 2:
                    arrayToUpdate[2]++;
                    break;
                case 3:
                    arrayToUpdate[3]++;
                    break;
                case 4:
                    arrayToUpdate[4]++;
                    break;
                case 5:
                    arrayToUpdate[5]++;
                    break;
                case 6:
                    arrayToUpdate[6]++;
                    break;
                default:
                    arrayToUpdate[0]++;
                    break;
            }
        }
        static Int32 RNGDiceRoll(RNGCryptoServiceProvider Provider)
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
