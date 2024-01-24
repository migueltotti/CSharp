namespace Ex_8_9
{
    // Implementar ordenacao por ID, remocao de contas, visualizacao de contas individuas e de todas as contas, apenas 'senha' do 'gerente' e alguma forma de mostrar todas as alteracoes e acoes realizadas no dia, apenas com acesso do 'gerente' com 'senha'
    class Clientes
    {
        private int id;
        private double saldo;
        private double fatura;
        public static int Qtde_Clientes=0;

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

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes[] ContasCorrentes = new Clientes[5];

            int qtde_clientes, i=0; 
            char escolha = 'n';

            //            Console.Write("Impira a quantidade de Clientes: ");
            //            qtde_clientes = int.Parse(Console.ReadLine());

            //PreencherVetor(ContasCorrentes);

            while(escolha != 's' && escolha != 'S')
            {
                Console.Write("Inserir Novo Cliente [C]: \nRealizar Operacoes [O]: \nRealizar Tranferencias [T]: \nMostrar todas as Contas [M]: \nSair [S]: \n:");
                escolha = char.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 'C':
                    case 'c':
                        //AddClientes(ContasCorrentes, LeClientes());
                        if(Clientes.Qtde_Clientes < 5)
                        {
                            ContasCorrentes.SetValue(LeClientes(), Clientes.Qtde_Clientes);
                            Console.WriteLine("Conta Adicionada!\n");
                            Clientes.Qtde_Clientes++;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de Clientes Limite Alcansada!");
                        }
                        break;
                    case 'O':
                    case 'o':
                        Console.Write("Insira a quantidade de operacoes realizadas no dia: ");
                        int qtde_op = int.Parse(Console.ReadLine());
                        Op(ContasCorrentes, qtde_op);
                        break;
                    case 'T':
                    case 't':
                        TR(ContasCorrentes);
                        Console.WriteLine("Transferencia Concluida!\n");
                        break;
                    case 'M':
                    case 'm':
                        for(int j = 0; j < Clientes.Qtde_Clientes; j++)
                        {
                            Console.WriteLine("Conta ID.: {0}", ContasCorrentes[j].Id);
                            Console.WriteLine("Saldo....: {0}", ContasCorrentes[j].Saldo);
                            Console.WriteLine("Fatura...: {0}\n", ContasCorrentes[j].Fatura);
                        }
                        break;
                    default:
                        if(escolha != 's')
                        {
                            Console.WriteLine("Codigo Incorreto!!\n");
                        }                        
                        break;
                }

                Console.WriteLine("-----------------------------------\n");
            }
        }

        public static void PreencherVetor(Clientes[] vetor)
        {
            for(int i = 0;i < vetor.Length; i++)
            {
                Clientes c = new Clientes();

                vetor[i] = c;
            }
        }

        public static Clientes LeClientes()
        {
            Clientes C;

            C = new Clientes();

            Console.Write("Informe um novo ID: ");
            C.Id = int.Parse(Console.ReadLine());

            Console.Write("Infome o saldo: ");
            C.Saldo = double.Parse(Console.ReadLine());

            return C;
        }



        // nao consegui pensar em algo para ordenar aqui
        public static void AddClientes(Clientes[] ContasCorrentes, Clientes NovoCLiente)
        {
            for(int i = 0; i < ContasCorrentes.Length; i++)
            {
                if (ContasCorrentes[0].Id == 0) // vetor vazio
                {
                    ContasCorrentes[0] = NovoCLiente;
                }

                if (ContasCorrentes[i].Id > NovoCLiente.Id)
                {
                    ContasCorrentes[i + 1] = ContasCorrentes[i];
                    ContasCorrentes[i] = NovoCLiente;
                }
                else if (ContasCorrentes.Length - 1 == i)
                {
                    ContasCorrentes[i] = NovoCLiente;
                }
            }
        }

        public static void Op(Clientes[] Contas, int qtde)
        {
            int ID;
            int realizadas=0;
            int i = 0, j = 0;
            bool achou = false;

            while(achou != true)
            {    
                Console.Write("Informe o ID: ");
                ID = int.Parse(Console.ReadLine());
                // encontrar a conta
                for(i = 0; i < Clientes.Qtde_Clientes; i++)
                {
                    if (ID == Contas[i].Id)
                    {
                        achou = true;
                        for (j = 0; j < qtde; j++)
                        {
                            Console.Write("Infome o tipo da operadao [C, D]: ");
                            string tipoOp = Console.ReadLine();
                            Console.Write("Valor da operacao: ");
                            int valor = int.Parse(Console.ReadLine());
                            Contas[i].Operacao(tipoOp, valor);
                            realizadas++;
                        }
                    }
                }
                if (achou == false)
                {
                    Console.WriteLine("ID nao encontrado! Tente novamente.");
                }
            }

            if(realizadas == qtde)
            {
                Console.WriteLine("Operacoes Realizadas com Sucesso!\n");
            }
            
        }

        public static void TR(Clientes[] Contas)
        {
            int i=0, j=0, ID1, ID2;
            bool achou1 = false, achou2 = false;
            double valor;

            Console.Write("Informe o ID da conta principal: ");
            ID1 = int.Parse(Console.ReadLine());

            while (achou1 != true)
            {
                if(ID1 == Contas[i].Id)
                {
                    achou1 = true;
                    Console.Write("Informe o ID da conta a ser transferida: ");
                    ID2 = int.Parse(Console.ReadLine());

                    while (achou2 != true)
                    {
                        if(ID2 == Contas[j].Id) 
                        {
                            achou2 = true;
                            Console.Write("Informe o valor: ");
                            valor = double.Parse(Console.ReadLine());

                            Contas[i].Transferencia(valor, Contas[j]);
                        }

                        j++;
                    }
                }

                i++;
            }
        }
    }
}
