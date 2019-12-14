using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_IoC_DI
{
    interface IClass
    {
        string Data { get; set; }
        void PrintInfo();
    }
}
