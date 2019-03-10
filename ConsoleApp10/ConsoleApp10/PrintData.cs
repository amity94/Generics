using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class PrintData<T>
    {
        private T data;

        public PrintData(T data)
        {
            this.data = data;
        }

        public void Print()
        {
            Console.WriteLine("!================= " + data + " =================!");
        }
    }
}
