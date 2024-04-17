using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_5
{
    internal class ContaBancaria
    {
        public int NumConta { get; private set; }
        private string _titularConta;
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titularConta, double saldo = 0.00)
        {
            NumConta = numConta;
            _titularConta = titularConta;
            Saldo = saldo;
        }

        /*public ContaBancaria(int numConta, string titularConta)
        {
            NumConta = numConta;
            _titularConta = titularConta;
            Saldo = 0.00;
        }*/

        public string TitularConta
        {
            get{
                return _titularConta;
            }
            set{
                if(value.Length > 0) 
                { 
                    _titularConta = value; 
                }
            }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumConta +", Titular: " + _titularConta + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
