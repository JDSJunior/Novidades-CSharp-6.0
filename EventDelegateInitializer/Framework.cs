using System;
using static System.Console;

namespace EventDelegateInitializer
{
    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        WriteLine($"Paga valor de {valor} no boleto");
    //    }
    //}

    //public delegate void PagarEvent(double valor);

    public class Pedido
    {
        //Boleto Boleto = new Boleto();

        public string  Cliente { get; set; }

        public EventHandler<EventArgs> Pagar { get; set; }

        //public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            //delegação com delegate / event
            //Pagar(valor);
            Pagar(this, new EventArgs());
        }

    }
}
