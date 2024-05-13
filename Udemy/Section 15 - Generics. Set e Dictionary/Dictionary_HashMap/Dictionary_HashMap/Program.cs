namespace Dictionary_HashMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997862321";
            cookies["phone"] = "980862321";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if(cookies.ContainsKey("email")) 
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There`s no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("\nAll cookies:");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
