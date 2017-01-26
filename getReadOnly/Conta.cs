using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getReadOnly
{
    class Conta
    {
        //para manter os campos encapsulados 
        //usamos as properties para exibir seus valores
        private double _saldo = 1000;

        //usando somente o get a propiedade apenas exibe o valor do campo
        //nao tendo como alterar seu valor
        public double Saldo { get { return this._saldo; }  }

        //usando o private a propriedade é alterada somente dentro
        //do escopo da classe
        //public double Saldo { get; private set; }

        public string Cliente { get; set; }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            _saldo -= valor;
        }

        //metodo tradicional de mostrar valores de campos privados
        //public void getSaldo()
        //{
        //    Console.WriteLine($"Saldo do cliente {this.Cliente} = {this.Saldo}");
        //}
    }
}
