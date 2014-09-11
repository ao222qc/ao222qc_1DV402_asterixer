using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.cs
{
    class Program
    {
        static void Main(string[] args)
           
			{
              
			  for (int rader = 0; rader < 25; rader++)
              {
                  switch (rader) 
                    { 
                        case 0: case 3: case 6: case 9: case 12: case 15: case 18: case 21: case 24: 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                            
                        case 1: case 4: case 7: case 10: case 13: case 16: case 19: case 22: case 25:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }

                  for (int columns = 0; columns < 39; columns++)

                  {
                      Console.Write("* ");
                  }
                   
                    Console.WriteLine();

                    if (rader % 2 == 0)
                  {
                      Console.Write(" ");

                  }


                    
               
              } 
        }
    }
}

