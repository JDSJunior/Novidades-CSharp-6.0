using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 999999999;
            int Y = 0;
            int result = 0;
            try
            {
                result = X / Y;
                result =checked( X * Y);
                WriteLine($"O resultado é {result}");
            }
            //metodo tradicional de tratar Excessoes
            //catch(DivideByZeroException Ex)
            //{
            //    WriteLine(Ex.Message);
            //}
            //catch(OverflowException Ex)
            //{
            //    WriteLine(Ex.Message);
            //}
            //catch(ArithmeticException Ex)
            //{
            //    WriteLine(Ex.Message);
            //}

            //trata a execessao pela de acordo com a mensagem que a variavel Ex contém
            catch(Exception Ex) when (Ex.Message.ToUpper().Contains("ESTOURO"))
            {
                WriteLine(Ex.Message);
            }
            catch (Exception Ex) when (Ex.Message.ToUpper().Contains("ZERO"))
            {
                WriteLine(Ex.Message);
            }
        }
    }
}
