using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bows_And_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            Play playTheGame = new Play();
            playTheGame.PlayBullsAndCows();
        }
    }
}