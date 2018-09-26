using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    class Reader
    {
        string fileName;
        public string data;
        public Reader(string fn) { fileName = fn; }
            
        public void Read()
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            data = r.ReadToEnd();
            r.Close();
            s.Close(); }
    }
   
}
