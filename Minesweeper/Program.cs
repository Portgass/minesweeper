﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    class Program {
        static void Main(string[] args) {
            GameController gm = new GameController();
            gm.InitializeGame();
            Console.ReadKey();
        }
    }
}
