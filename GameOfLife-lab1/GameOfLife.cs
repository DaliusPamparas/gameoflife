using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_lab1
{
    class GameOfLife
    {
        
        private string[,] _FieldOfGame = new string [20, 20];




      

             





        //methods   -Fill List med random
        //methods   -Check Live or dead
        //methods   -Write list
        public void FillListSymbol()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    _FieldOfGame[i, j] = "*";
                }
            }
        }

        public void FillListRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    
                    Console.Write(rand.Next(100));
                    if (j == 19)
                    {
                        Console.Write("\n");
                    }

                    //if ( co < 50)
                    //{
                    //    _FieldOfGame[i, j] ="0" ;
                    //}
                    //else
                    //{
                    //    _FieldOfGame[i, j] = " ";
                    //}




                }
            }


        }

        public void WriteOutList()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(_FieldOfGame[i, j]);
                    if (j == 19)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }






    }
}
