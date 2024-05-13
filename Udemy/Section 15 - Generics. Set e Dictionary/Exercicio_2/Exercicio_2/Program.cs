namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidates = new Dictionary<string, int>();

            string path;

            string[] lines;
            string name;
            int votes;

            try
            {
                Console.Write("Enter file full path: ");
                path = Console.ReadLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        lines = sr.ReadLine().Split(",");
                        name = lines[0];
                        votes = int.Parse(lines[1]);

                        if(candidates.ContainsKey(name))
                        {
                            candidates[name] += votes;
                        }
                        else
                        {
                            candidates.Add(name, votes);
                        }
                    }

                    foreach(KeyValuePair<string, int> item in candidates)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
