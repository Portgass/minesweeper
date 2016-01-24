﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper.Controllers;

namespace Minesweeper {
    class Program {
        static void Main(string[] args) {

            // Minesweeper
            // Petr Svoboda, 1. ročník
            // Zimní semestr 2015/2016
            // Programování I - NPRG030

            var game = new GameController();
            game.Start();
        }
    }
}
