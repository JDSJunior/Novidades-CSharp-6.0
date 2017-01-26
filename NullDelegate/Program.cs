using System;
using static System.Console;
using static System.Convert;

namespace NullDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe o valor do pedido:");
            var valor = ToInt32(ReadLine());
            var pedido = new Pedido();
            //delegate nao aponta para metodo
            //pedido.Pagar += Pedido_Pagar;

            //expressa lambda sendo atribuiada a o delegate
            pedido.Pagar += v => WriteLine($"Pago valor de {v} no boleto");
            pedido.Fechar(valor);
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor {valor} no boleto.");
        //}
    }
}
