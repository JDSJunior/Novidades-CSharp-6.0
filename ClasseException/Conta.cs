using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClasseException
{
    class Conta
    {
        private double _saldo;
        private const double LIMITE = -500;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor >= _saldo + LIMITE)
                throw new SaldoInsuficienteException("Saldo Insuficiente");
                _saldo = _saldo - valor;
        }

        public double getSaldo()
        {
            return this._saldo;
        }
    }

    //exception gerada automaticamente pelo ide
    [Serializable]
        public class SaldoInsuficienteException : Exception
        {
            public SaldoInsuficienteException()
            {
            }

            public SaldoInsuficienteException(string message) : base(message)
            {
            }

            public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }

