using System.Collections.Generic;

namespace ContasBancarias
{
    // alguma forma de mostrar todas as alteracoes e acoes realizadas no dia, apenas com acesso do 'gerente' com 'senha'
    // implementar uma classe gerente e dividir as contas pela ocupacao(Gerente, Cliente) e colocar restricoes;
    class Clientes
    {
        private int id;
        private double saldo;
        private double fatura;
        public static int Qtde_Clientes = 0;

        public Clientes()
        {
            this.id = 0;
            this.saldo = 0.00;
            this.fatura = 0.00;
        }

        public Clientes(int id, double saldo)
        {
            this.id = id;
            this.saldo = saldo;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID: {0}", this.id);
            Console.WriteLine("Saldo: {0}\n", this.saldo);
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public double Fatura
        {
            get
            {
                return this.fatura;
            }
            set
            {
                this.fatura = value;
            }
        }

        public void Operacao(string Tipo_Op, double valor)
        {
            switch (Tipo_Op)
            {
                case "C":
                case "c":
                    this.fatura += valor;
                    break;
                case "D":
                case "d":
                    this.saldo -= valor;
                    break;
            }
        }

        public void Transferencia(double valor, Clientes clienteT)
        {
            clienteT.saldo += valor;

            this.saldo -= valor;
        }

        public void Info()
        {
            Console.WriteLine("Conta ID.: {0}", this.Id);
            Console.WriteLine("Saldo....: {0}", this.Saldo);
            Console.WriteLine("Fatura...: {0}\n", this.Fatura);
        }

    }

    class Gerente : Clientes
    {

        public Gerente() : base() { }
    }

    static class SENHA
    {
        private static string senha = "120822";

        public static string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            List<Clientes> Contas = new List<Clientes>();

            string escolha = "";

            while (escolha != "s" && escolha != "S")
            {
                Console.Write("Inserir Novo Cliente [C]: \nRealizar Operacoes [O]: \nRealizar Tranferencias [T]: \nRemocao de conta [R]: \nMostrar Contas [M]: \nSair [S]: \n:");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "C":
                    case "c":
                        if (Clientes.Qtde_Clientes < 5)
                        {
                            Contas.Add(LeClientes(Contas));
                            Console.WriteLine("Conta Adicionada!\n");
                            Clientes.Qtde_Clientes++;
                            Contas = Contas.OrderBy(x => x.Id).ToList();
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de Clientes Limite Alcansada!");
                        }
                        break;
                    case "O":
                    case "o":
                        Console.Write("Insira a quantidade de operacoes realizadas no dia: ");
                        int qtde_op = int.Parse(Console.ReadLine());
                        Op(Contas, qtde_op);
                        break;
                    case "T":
                    case "t":
                        TR(Contas);
                        Console.WriteLine("Transferencia Concluida!\n");
                        break;
                    case "R":
                    case "r":
                        RemoverCliente(Contas);
                        Console.WriteLine("Conta removida com sucesso!");
                        break;
                    case "M":
                    case "m":
                        Console.Write("Selecione sua Ocupacao.\nCliente [C]/ Gerente [G]: ");
                        string ocupacao = Console.ReadLine();

                        switch (ocupacao)
                        {
                            case "C":
                            case "c":
                                Clientes C;
                                bool achou = false;

                                while (achou == false)
                                {
                                    Console.Write("Informe seu ID: ");
                                    int ID = int.Parse(Console.ReadLine());
                                    Console.WriteLine();

                                    C = Contas.Find(x => x.Id == ID);
                                    if (C != null)
                                    {
                                        C.Info();
                                        achou = true;
                                    }
                                }
                                break;
                            case "G":
                            case "g":
                                string senha = "";
                                while (senha != SENHA.Senha)
                                {
                                    Console.Write("Insira a senha: ");
                                    senha = Console.ReadLine();

                                    if (senha == SENHA.Senha)
                                    {
                                        Console.WriteLine();
                                        foreach(Clientes c in Contas)
                                        {
                                            c.Info();
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Opcao Incorreta!");
                                break;
                        }
                        break;
                    default:
                        if (escolha != "s")
                        {
                            Console.WriteLine("Codigo Incorreto!!\n");
                        }
                        break;
                }

                Console.WriteLine("-----------------------------------\n");
            }
        }

        public static Clientes LeClientes(List<Clientes> Contas)
        {
            Clientes C;
            bool existe = false;

            C = new Clientes();

            while (existe == false)
            {
                Console.Write("Informe um novo ID: ");
                C.Id = int.Parse(Console.ReadLine());

                if (Contas.Exists(x => x.Id == C.Id)) // verifica a existencia de ID ja existente, return bool
                {
                    Console.WriteLine("ID ja cadastrado!");
                }
                else
                {
                    existe = true;
                    Console.Write("Infome o saldo: ");
                    C.Saldo = double.Parse(Console.ReadLine());
                    
                }
            }

            return C;
        }

        public static void RemoverCliente(List<Clientes> Contas)
        {
            int ID = 0;
            bool achou = false;
            Clientes C;

            Console.Write("Insira o ID da conta que deseja remover: ");
            ID = int.Parse(Console.ReadLine());

            while (achou == false)
            {
                C = Contas.Find(x => x.Id == ID);
                if (C != null) 
                {
                    Contas.Remove(C);
                    achou = true;
                }
                else Console.WriteLine("ID nao encontrado! Tente novamente");
            }
        }

        public static void Op(List<Clientes> Contas, int qtde)
        {
            int ID;
            int realizadas = 0;
            int i = 0;
            bool achou = false;
            Clientes C;

            while (achou != true)
            {
                Console.Write("Informe o ID: ");
                ID = int.Parse(Console.ReadLine());
                
                C = Contas.Find(x => x.Id == ID);
                if(C != null) // ID encontrado
                {
                    achou = true;
                    for (i = 0; i < qtde; i++)
                    {
                        Console.Write("Infome o tipo da operadao [C, D]: ");
                        string tipoOp = Console.ReadLine();
                        Console.Write("Valor da operacao: ");
                        int valor = int.Parse(Console.ReadLine());
                        C.Operacao(tipoOp, valor);
                        realizadas++;
                    }
                }
                else
                {
                    Console.WriteLine("ID nao encontrado! Tente novamente.");
                }
            }

            if (realizadas == qtde)
            {
                Console.WriteLine("Operacoes Realizadas com Sucesso!\n");
            }

        }

        public static void TR(List<Clientes> Contas)
        {
            int ID1, ID2;
            bool achou1 = false, achou2 = false;
            double valor;
            Clientes C1, C2;

            Console.Write("Informe o ID da conta principal: ");
            ID1 = int.Parse(Console.ReadLine());

            while (achou1 != true)
            {
                C1 = Contas.Find(x => x.Id == ID1);

                if (C1 != null) 
                {
                    achou1 = true;

                    while(achou2 != true)
                    {
                        Console.Write("Informe o ID da conta a ser transferida: ");
                        ID2 = int.Parse(Console.ReadLine());
                        C2 = Contas.Find(x => x.Id == ID2);

                        if (C2 != null)
                        {
                            achou2 = true;
                            Console.Write("Informe o valor: ");
                            valor = double.Parse(Console.ReadLine());

                            C1.Transferencia(valor, C2);
                        }
                    }
                }
            }
        }
    }
}

