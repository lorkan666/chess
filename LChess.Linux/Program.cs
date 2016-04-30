#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using LChess;
#endregion

namespace LChess.Linux
{
    static class Program
    {
        private static LChessGame game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            game = new LChessGame();
            game.Run();
        }
    }
}
