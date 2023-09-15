namespace Part_1_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gabe
            string firstName = "Gabe";
            string favMovie = "The Matrix";
            string quote = "It's a fez. Fezzes are cool.";
            Console.WriteLine($"Hello, {firstName}.");
            Console.WriteLine($"Have you seen {favMovie}?");
            Console.WriteLine("I have a fun trick! I'll print the title in all caps and see if it contains 'The' in all caps. If it does, I'll print out 'true'.");
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

            Console.WriteLine("              ____==========_______                 __.-._");
            Console.WriteLine("   _--____   |    | \"\"  \" \"|       \\                '-._\"7'");
            Console.WriteLine("  /  )8}  ^^^| 0  |  =     |  o  0  |                /'.-c");
            Console.WriteLine("                                                     |  /T");
            Console.WriteLine("                                                    _)_/LI");
        }
    }
}