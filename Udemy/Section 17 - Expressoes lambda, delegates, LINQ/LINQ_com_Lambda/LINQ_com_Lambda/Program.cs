using LINQ_com_Lambda.Entities;

namespace LINQ_com_Lambda
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tool", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Electronics", Tier = 1 };

            // Create Data Source
            List<Product> products = new List<Product>() {
                new Product() { ID = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { ID = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { ID = 3, Name = "Tv", Price = 1700.0, Category = c3},
                new Product() { ID = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() { ID = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { ID = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() { ID = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() { ID = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() { ID = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() { ID = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() { ID = 11, Name = "Level", Price = 70.0, Category = c1},
            };

            // Create query
            var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            // .Where() retorna uma colecao IEnumerable<> com todos os elementos que satisfazem um predicado(expressao lambda)

            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(x => x.Category.Name == "Tool").Select(x => x.Name);
            // .Select() vai retornar uma colecao de string, ja que foi apresentado na expressao lambda o 'nome do produto' (string)

            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            // Nesse caso o .Select() vai instanciar um 'objeto anonimo', nao existe uma classe para esse objeto, e assim podemos inserir quaisquer propriedades dos objetos produtos
            // CategoryName = x.Category.Name eh apenas um apelido dado a propriedade name de category pq ja existia uma propiedade name inserida anteriormente na instanciacao do objeto anonimo

            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            // .OrderBy() vai ordenar a colecao IEnumerable<> gerada a partir de um delegate (expressao lambda, preco), porem caso a comparacao de igual, sera feita outra comparacao usando o .ThenBy() utilizando outro delegate (expressao lambda) como argumento para ordenar

            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME:", r4);

            var r5 = r4.Skip(2).Take(4);
            // vai pular os dois primeiro items da colecao r4 e pegar os proximso 4 items e inserir na coleca r5

            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default teste1: " + r6);
            // vai pegar o primeiro elemento da colecao products ou vai retornar nulo se estiver vazia

            var r7 = products.Where(x => x.Price > 3000).FirstOrDefault();
            Console.WriteLine("First or default teste2: " + r7);
            
            Console.WriteLine();

            var r8 = products.Where(x => x.ID == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(x => x.ID == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            // vai pegar o objeto que tenha ID == 3, como nao se repete vai retornar apenas 1.
            // O metodo SingleOrDefualt() vai assegurar que sera retornado apenas 1 objeto da colecao, e caso nao seja encontrado nenhum objeto que satizfaca aquela expressao lambda, sera retornado null (default)
            //ele deve ser usado APENAS quando o resultado sera UM objeto ou NENHUM objeto, caso contrario dara ERRO!
            
            Console.WriteLine();

            var r10 = products.Max(x => x.Price);
            Console.WriteLine("Max price: " + r10);
            // .Max() vai pegar o Maior objeto com base em um criterio estabelecido pela expressao lambda
            // caso nao tenha nenhum argumento no metodo .Max() ele fara a comparacao com base no metodo sobreescrito de Equals() e GetHashCode() do objeto, caso nao tenha dara um ERRO!

            var r11 = products.Min(x => x.Price);
            Console.WriteLine("Max price: " + r11);

            var r12 = products.Where(x => x.Category.ID == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            // o metodo .Sum() vai retornar um double/int/float... com a soma de todos os objetos com base em um delegate (expressao lambda), nesse caso vai somar todos os precos dos objetos

            var r13 = products.Where(x => x.Category.ID == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            // o metodo .Average() vai retornar um double/int/float ... com a media de todos os objetos com base em um delegate (expressao lambda), caso seja um conjunto vazio lancara um ERRO! 

            var r14 = products.Where(x => x.Category.ID == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);
            // Para resolver o problema de uma colecao vazia, podemos selecionar todos os elementos e pegar apenas o Price de todos e colocar em uma colecao, dai aplicar o metodo DefaultIfEmpty() que vai retornar um valor passado como parametro caso a colecao seja vazia, se nao for vai continuar normalmente e calcular a media com Average().

            var r15 = products.Where(x => x.Category.ID == 1).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate sum prices: " + r15);
            // Utilizando o Select().Aggregate() podemos personalisar alguma operacao usando lambda expression e ainda definir um valor inicial como primeiro argumento do metodo para realizar a operacao, essa eh uma forma de definir um valor padrao para soma e subtracao quando o conjunto for vazio

            Console.WriteLine();

            var r16 = products.GroupBy(x => x.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }



        }
    }
}
