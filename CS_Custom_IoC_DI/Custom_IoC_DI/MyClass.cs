using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_IoC_DI
{
    class MyClass : IClass
    {
        private int id;
        public string Data { get; set; }
        public void PrintInfo() {
            Console.WriteLine($"{id} {Data}");
        }
    }
}
