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
            bool go = true;

            GameOfLife myGameOfLife = new GameOfLife();
            myGameOfLife.FillListRandom();
            do
            {
                myGameOfLife.CheckLiveOrDead();
                myGameOfLife.WriteOutList();
            }
            while( go);
           

            Console.ReadKey();
        }
    }
}
