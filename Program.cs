using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bows_And_Cows
{
    /// <summary>
    /// Falling rock game made with list and struct
    /// </summary>
    /// 
    /// <copyright>
    /// (c) Vasil Hristov, 2012 - http://www.vhristov.com
    /// </copyright>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Play playTheGame = new Play();
            playTheGame.PlayBullsAndCows();
        }
    }
}