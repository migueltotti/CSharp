using Exercicio_2.Entities;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post()
            {
                Moment = new DateTime(2018, 06, 21, 13, 05, 44),
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Likes = 12
            };

            post1.AddComment(new Comment() { Text = "Have a nice trip" });
            post1.AddComment(new Comment() { Text = "Wow that's awesome" });

            Post post2 = new Post()
            {
                Moment = new DateTime(2018, 07, 28, 23, 14, 19),
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5
            };

            post2.AddComment(new Comment() { Text = "Good night" });
            post2.AddComment(new Comment() { Text = "May the Force be with you" });

            Console.WriteLine(post1);

            Console.WriteLine(post2);
        }
    }
}
