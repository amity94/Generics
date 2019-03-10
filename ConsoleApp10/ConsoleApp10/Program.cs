using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            PrintData<int> pdata = new PrintData<int>(10);
            pdata.Print();



        }
    }
}
