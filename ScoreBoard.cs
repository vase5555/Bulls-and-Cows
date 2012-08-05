using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bows_And_Cows
{
   public class ScoreBoard
    {
        string[] nicknames = new string[5];
        int[] attemts = new int[5];

        public ScoreBoard()
        {
            for (int i = 0; i < attemts.Length; i++)
            {
                this.attemts[i] = int.MaxValue;
            }
        }

        private void Change(int number, int position, string nickname)
        {
            int oldValue = 0;
            string oldName = string.Empty;
            oldValue = number;
            oldName = nickname;
            for (int i = position; i < 5; i++)
			{
                int localValue = this.attemts[i];
                string localNickname = this.nicknames[i];
                this.attemts[i] = oldValue;
                this.nicknames[i] = oldName;
                oldValue = localValue;
                oldName = localNickname;
                
			}
        }

        public bool CheckForAdding(int attemts)
        {
            for (int i = 0; i < 5; i++)
			{
			    if(this.attemts[i]>attemts)
                {
                    return true;
                }
			}
            return false;
        }

        public void AddNewScore(string nickname,  int attemts)
        {
            for (int i = 0; i < 5; i++)
			{
			    if(this.attemts[i]>attemts)
                {
                    Change(attemts, i, nickname);
                    break;
                }
			}
        }

        public void ShowScoreBoard()
        {
            for (int i = 0; i < 5; i++)
            {
                if (attemts[i] != int.MaxValue)
                {
                    Console.WriteLine(i + 1 + ". " + this.nicknames[i] + " --> " + this.attemts[i] + " guesses");
                }
                
            }
        }

        public int[] ScoreAttemts
        {
            get
            {
                return this.attemts;
            }
        }

        public string[] ScoreNickNames
        {
            get
            {
                return this.nicknames;
            }
        }
    }
}
