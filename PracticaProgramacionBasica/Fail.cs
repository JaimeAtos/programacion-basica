using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramacionBasica
{
    internal class Fail
    {
        public string error()
        {
            int fail = 0, aux;
            try
            {
                aux =  4/fail;
            }
            catch(Exception e) 
            {
                Console.WriteLine("Error");
                return e.Message;
            }
            return "";
        }
    }
}
