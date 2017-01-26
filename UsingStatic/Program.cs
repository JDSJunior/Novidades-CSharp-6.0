using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static faz uso de classes e metodos estaticos
//para redução de codigo
using static System.Console;
using static UsingStatic.Util;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando o metodo WriteLine e ReadKey
            //usando using static
            WriteLine("Usando Using static");
            //using static aninhado 
            WriteLine(Somar(10, 25));
            ReadKey();
        }
    }
}
