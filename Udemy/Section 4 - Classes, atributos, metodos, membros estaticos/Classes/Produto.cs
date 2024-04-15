using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Classes
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtde;

        public Produto(string nome, double preco, int qtde)
        {
            this._nome = nome;
            this._preco = preco;
            this._qtde = qtde;
        }
        /*
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtde = 5;
        } */

        public Produto() { }

        public string nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double preco
        {
            get { return _preco; }
        }

        public int quantidade
        {
            get { return _qtde; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _qtde;
        }

        public void AdicionarProdutos(int qtde)
        {
            this._qtde += qtde;
        }

        public void RemoverProdutos(int qtde)
        {
            this._qtde -= qtde;
        }

        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _qtde + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
