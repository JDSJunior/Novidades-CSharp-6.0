using System;
using static System.Console;

namespace NullDelegate
{
    public delegate void PagarEvent (double valor);
    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        WriteLine($"Pago valor de: {valor}.");
    //    }
    //}
    public class Pedido
    {

        public event PagarEvent Pagar;
        //Boleto boleto = new Boleto();
        public void Fechar(double valor)
        {
            //delegação
            //nao gera a excessao de nullreference
            Pagar?.Invoke(valor);
        }

        
    }
}
