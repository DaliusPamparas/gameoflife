using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_lab1
{
    class GameOfLife
    {
        private int neirbours;
        private string[,] _FieldOfGame = new string [20, 20];


        //methods   -Fill List med random
        //methods   -Check Live or dead
        //methods   -Write list
        public void FillListSymbol()
        {
            for (int i = 0; i == 19; i++)
            {
                for (int j = 0; j == 19; j++)
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
                    
                   
                    if( rand.Next(10)<5)
                    {
                        _FieldOfGame[i, j] = " ";
                    }
                    else
                    {
                        _FieldOfGame[i, j] = "*";
                    }


                }
            }


        }
        public void CheckLiveOrDead()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    CountNeigbours(i, j);
                    //cell empty
                    if (_FieldOfGame[i, j] ==" ")
                    {
                        
                        if (neirbours == 3)
                        {
                            _FieldOfGame[i, j] = "*";
                           
                        }
                    }
                    //cell is live
                    else
                    {
                        switch (neirbours)
                        {
                            case 1:
                                _FieldOfGame[i, j] = " ";
                                break;
                            case 4://dead
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                _FieldOfGame[i, j] = " ";
                                break;

                            
                        }
                    }
                    
                   
                }
            }
        }

       public int CountNeigbours(int i, int j)
        {
            neirbours = 0;
            //left top corner
            if(i == 0 && j == 0)
            {
                if (_FieldOfGame[i,j++]=="*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j++] == "*")
                {
                    neirbours++;
                }
                
            }

            //right top corner
            if (i == 0 && j == 19)
            {
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
            }
            //left bottom corner
            if (i == 19 && j == 0)
            {
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j++] == "*")
                {
                    neirbours++;
                }
            }
            //right bottom corner
            if (i == 19 && j == 19)
            {
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
            }
            //top line
            if (i == 0 && j != 0 && j != 19)
            {
                if (_FieldOfGame[i, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j++] == "*")
                {
                    neirbours++;
                }
            }
            //bottom line
            if (i == 19 && j != 0 && j != 19)
            {
                if (_FieldOfGame[i, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j++] == "*")
                {
                    neirbours++;
                }
            }
            //left line
            if (j == 0 && i != 0 && i != 19)
            {
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j++] == "*")
                {
                    neirbours++;
                }
            }
            //right line
            if (j == 19 && i != 0 && i != 19)
            {
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j--] == "*")
                {
                    neirbours++;
                }
            }
            //area in the middle
            if (j > 0 && i > 0 && i < 19 && j < 19)
            {
                
                if (_FieldOfGame[i--, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i--, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i, j++] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j--] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j] == "*")
                {
                    neirbours++;
                }
                if (_FieldOfGame[i++, j++] == "*")
                {
                    neirbours++;
                }
            }
            return neirbours;
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
