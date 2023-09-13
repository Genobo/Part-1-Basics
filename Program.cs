namespace Part_1_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gabe
            string firstName = "Gabe";
            string favMovie = "The Matrix";
            string quote = "It's a fez. I wear a fez now.";
            Console.WriteLine($"Hello, {firstName}.");
            Console.WriteLine($"Have you seen {favMovie}?");
            Console.WriteLine("I have a fun trick! I'll see if the title contains 'The' in all caps. If it does, I'll print out 'true'.");
            favMovie = favMovie.ToUpper();
            Console.WriteLine($"{ favMovie.Contains("THE")}");
            Console.WriteLine("I can replace letters as well. I'll show you!");
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine($"{favMovie} is my favorite movie!");

            Console.WriteLine("Now I'm gonna remove the vowels of my favorite quote!");
            quote = quote.Replace("a", " ");
            quote = quote.Replace("e", " ");
            quote = quote.Replace("I", " ");
            quote = quote.Replace("o", " ");
            Console.WriteLine($"{quote}");
        }
    }
}