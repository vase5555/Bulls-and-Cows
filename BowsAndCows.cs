using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bows_And_Cows
{
   public class BowsAndCows
    {
        private int[] number = new int[4];
        private int attempts = 0;
        private bool useHelp = false;
        private Random generator = new Random(DateTime.Now.Millisecond);
        private int bulls = 0;
        private int cows = 0;
        private bool[] isHelpThisNumber = new bool[4];

        public BowsAndCows()
        {
            for (int i = 0; i < 4; i++)
            {
                this.number[i] = generator.Next(0, 10);
            }
        }

        public bool FindBowsAndCows(int[] numberToSearch)
        {
            int bulls = 0;
            int cows = 0;
            int[] currentNumber = new int[4];
            for (int i = 0; i < 4; i++)
			{
			    currentNumber[i] = this.number[i];
			}
            for (int i = 0; i < 4; i++)
            {
                if (currentNumber[i] == numberToSearch[i])
                {
                    bulls++;
                    currentNumber[i] = -1;
                }
            }
            this.bulls = bulls;
            for (int i = 0; i < 4; i++)
            {
                if (currentNumber.Contains(numberToSearch[i]) == true)
                {
                    int index = Array.IndexOf(currentNumber, numberToSearch[i]);
                    cows++;
                    currentNumber[index] = -1;
                }
            }
            this.cows = cows;

            this.attempts++;
            if(bulls==4)
            {
                Console.WriteLine("Congratulations! You guessed the secret number in " + this.attempts + " attempts.");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong number! Bulls: "+bulls.ToString()+" Cows: "+cows.ToString());
                return false;
            }
        }

        public void Help()
        {
            int position = generator.Next(1, 5) - 1;
            Console.Write("The number looks like ");
            while (true)
            {
                if (this.isHelpThisNumber[position] == true)
                {
                    position = generator.Next(1, 5) - 1;
                }
                else
                {
                    this.useHelp = true;
                    this.isHelpThisNumber[position] = true;
                    break;
                }
                int check = 0;
                for (int i = 0; i < this.isHelpThisNumber.Length; i++)
                {
                    if (this.isHelpThisNumber[i] == true)
                    {
                        check++;
                    } 
                }
                if (check == 4)
                {
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (this.isHelpThisNumber[i]==true)
                {
                    Console.Write(number[i]);
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        public int Attemts
        {
            get
            {
               return this.attempts;
            }
        }

        public bool HasUseHelp
        {
            get
            {
                return this.useHelp;
            }
        }

        public int[] Number
        {
            //for testing
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public int Bulls
        {
            //for testing
            get
            {
                return this.bulls;
            }
        }

        public int Cows
        {
            //for testing
            get
            {
                return this.cows;
            }
        }

        public bool[] IsNumberShow
        {
            //for testing
            get
            {
                return this.isHelpThisNumber;
            }
        }
    }
}
