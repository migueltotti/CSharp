using System.IO;

namespace File_FileInfo_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\User\Documents\C#\file1.txt";
            string targetPath = @"C:\Users\User\Documents\C#\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // copia o conteudo de um arquivo para outro
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
