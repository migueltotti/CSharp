namespace Directory_DirectoryIndo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Documents\C#\myfolder";

            try
            {
                // retornando todas as pastas
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                // retornando todos os arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                string newPath = path + @"\newfolder";

                Directory.CreateDirectory(newPath);
                if(Directory.Exists(newPath))
                {
                    Console.WriteLine("\nCREATED DIRECTORY: newfolder \npath: " + newPath);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
