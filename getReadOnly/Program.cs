using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta() { Cliente = "Júnior" };

            c1.Depositar(250);

            Console.WriteLine($"Cliente: {c1.Cliente}. Saldo: {c1.Saldo}");
        }
    }
}
