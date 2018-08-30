using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.1
            /*  int i = 100;
               for(i =100; i < 203; i+=2)
               {
                   Console.WriteLine(i);
               }
               Assignment 1.2
              for(int j=202; j > 100; j -= 2)
               {
                   Console.WriteLine(j);
               }
               */

            // Assignment 1.3
            /*
            int i = 100;
            while (i < 202)
            {
                                                             
                switch (i)
                {
                    case 110:
                        
                        Console.WriteLine("This is a funny number");
                        break;
                    case 130:

                        Console.WriteLine("This is a funny number");
                        break;
                    case 140:

                        Console.WriteLine("This is a funny number");
                        break;

                    case 122:
                        
                        Console.WriteLine("This is my lucky number");
                        break;

                    case 198:

                        Console.WriteLine("Empty");
                        break;
                      
                }
                Console.WriteLine(i);
                i += 2;
            }
            */
            //Assignment 1.4
            for(int i =1; i<256; i++)
            {
                String hexValue = i.ToString("X");
                if (i < 10) { 
                Console.Write(i);
                }
                if (i > 9) {                  
                Console.Write(hexValue);
                    Console.Write("    ");
                }

            }
            Console.ReadKey();
        }
    }
}
