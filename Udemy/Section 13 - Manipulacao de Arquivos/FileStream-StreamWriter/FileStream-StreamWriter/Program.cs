namespace FileStream_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\User\Documents\C#\file1.txt";
            string targetpath = @"C:\Users\User\Documents\C#\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
