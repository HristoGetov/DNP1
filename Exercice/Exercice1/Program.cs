using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            /*  for(i =100; i < 203; i+=2)
               {
                   Console.WriteLine(i);
               }
              for(int j=202; j > 100; j -= 2)
               {
                   Console.WriteLine(j);
               }
               */
            while (i < 202)
            {
                Console.WriteLine(i);
                i += 2;
            }
            Console.ReadKey();
        }
    }
}
