using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    class Thread1
    {
        public static void RunT0()
        {
            string text = System.IO.File.ReadAllText(@"C:\ICT\CV\HristoGetovCV");
            Reader read = new Reader(text);
        }

    }
}
