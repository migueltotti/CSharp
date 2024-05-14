using LINQ_com_notacao_SQL.Entities;

namespace LINQ_com_notacao_SQL
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
            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            // .Where() retorna uma colecao IEnumerable<> com todos os elementos que satisfazem um predicado(expressao lambda)

            var r1 = 
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;

            Print("TIER 1 AND PRICE < 900:", r1);

            //var r2 = products.Where(x => x.Category.Name == "Tool").Select(x => x.Name);
            // .Select() vai retornar uma colecao de string, ja que foi apresentado na expressao lambda o 'nome do produto' (string)

            var r2 =
                from p in products
                where p.Category.Name == "Tool"
                select p.Name;

            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            // Nesse caso o .Select() vai instanciar um 'objeto anonimo', nao existe uma classe para esse objeto, e assim podemos inserir quaisquer propriedades dos objetos produtos
            // CategoryName = x.Category.Name eh apenas um apelido dado a propriedade name de category pq ja existia uma propiedade name inserida anteriormente na instanciacao do objeto anonimo

            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name,
                };

            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            // .OrderBy() vai ordenar a colecao IEnumerable<> gerada a partir de um delegate (expressao lambda, preco), porem caso a comparacao de igual, sera feita outra comparacao usando o .ThenBy() utilizando outro delegate (expressao lambda) como argumento para ordenar

            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME:", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 
                      select p)
                      .Skip(2)
                      .Take(4);
            // vai pular os dois primeiro items da colecao r4 e pegar os proximso 4 items e inserir na coleca r5

            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

            //var r6 = products.FirstOrDefault();
            var r6 = (from p in products 
                      select p)
                      .FirstOrDefault();
            Console.WriteLine("First or default teste1: " + r6);
            // vai pegar o primeiro elemento da colecao products ou vai retornar nulo se estiver vazia

            Console.WriteLine();

            //var r16 = products.GroupBy(x => x.Category);

            var r16 =
                from p in products
                group p by p.Category;
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
