using System;
using static System.Console;

namespace EventDelegateInitializer
{
    //iniciando delegate no object initializer
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe o valor do boleto:");
            double valor = Convert.ToDouble(ReadLine());
            var pedido = new Pedido()
            {
                Cliente = "Júnior",
                //Pagar = Pedido_Pagar
                Pagar = (s, e) => { WriteLine("Pago no boleto"); }
            };
            //pedido.Pagar += Pedido_Pagar;
            
            pedido.Fechar(valor);
        }

        //private static void Pedido_Pagar(object sender, EventArgs e)
        //{
        //    WriteLine($"Pago no boleto");
        //}

        //private static void Pedido_Pagar(double valor)
        //{
        //    Console.WriteLine($"Pago valor de {valor} no boleto.");
        //}
    }
}
