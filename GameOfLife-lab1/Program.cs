using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_lab1
{
    class Program
    {
        static void Main(string[] args)
        {


            GameOfLife myGameOfLife = new GameOfLife();
            myGameOfLife.FillListRandom();
            myGameOfLife.WriteOutList();

            Console.ReadKey();
        }
    }
}
