﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor a depositar:");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor a sacar:");
            var v2 = Convert.ToDouble(Console.ReadLine());

            var ca = new Conta();

            ca.Depositar(v1);
            ca.Sacar(v2);
            Console.WriteLine(ca.getSaldo());

            Console.ReadKey();
        }
    }
}
