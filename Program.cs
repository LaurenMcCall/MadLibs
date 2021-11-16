using System;

namespace madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome User
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to MadLibs!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.Write("\n");

            // Provide Instructions
            Console.WriteLine("You will be asked to provide different words for various parts of speech to build a fun story. ");
            Console.Write("\n");
            Console.WriteLine("Here we go! ");
            Console.WriteLine("\n");

            // Collecting and Assigning  Variables
            Console.WriteLine("Write an adjective: ");
            var adj1 = Console.ReadLine();
            Console.WriteLine("Write a verb (past tense): ");
            var verbed1 = Console.ReadLine();
            Console.WriteLine("Write another verb (past tense): ");
            var verbed2 = Console.ReadLine();
            Console.WriteLine("Write a person's name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Write a length of time: ");
            var time = Console.ReadLine();
            Console.WriteLine("Write a body part: ");
            var bodyPart = Console.ReadLine();
            Console.WriteLine("Write an interjection (like \"Hey!\"): ");
            var interjection = Console.ReadLine();
            Console.WriteLine("Write a superlative adjective (like \"wicked\" or \"prettiest\"): ");
            var superlative = Console.ReadLine();
            Console.WriteLine("Write a place: ");
            var place = Console.ReadLine();
            Console.WriteLine("Write an adverb: ");
            var adverb = Console.ReadLine();
            Console.WriteLine("Write a noun: ");
            var noun1 = Console.ReadLine();
            Console.WriteLine("Write a food: ");
            var food = Console.ReadLine();
            Console.WriteLine("Write a plural animal: ");
            var animal = Console.ReadLine();
            Console.WriteLine("Write another noun: ");
            var noun2 = Console.ReadLine();
            Console.WriteLine("Write a number: ");
            var number = Console.ReadLine();
            Console.WriteLine("Write another verb (past tense): ");
            var verbed3 = Console.ReadLine();
            Console.WriteLine("Write another adjective: ");
            var adj2 = Console.ReadLine();
            Console.WriteLine("Write a salutation (like \"Goodbye, Kyle!!\"): ");
            var salutation = Console.ReadLine();

            // Display the Mad Lib!
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Read your Mad Lib below!!!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.WriteLine($"It was a {adj1} summer afternoon when he {verbed1} by me and said, \"Hey.\" ");
            Console.WriteLine($"My eyes {verbed2} as my heartbeat fluttered. In that instant I knew {name} and I would ");
            Console.WriteLine($"love each other for {time}. ");
            Console.WriteLine("\n");
            Console.WriteLine($"\"Hey\", I said back. Then he looked deep into my {bodyPart} and replied ");
            Console.WriteLine($"\"{interjection}, you are the most {superlative} girl I have ever seen.\" ");
            Console.WriteLine("\n");
            Console.WriteLine($"We sat in the {place} and stared at each other for hours. As his hand {adverb} touched my hand, sparks flew. ");
            Console.WriteLine("\n");
            Console.Write($"We talked about {noun1} and other important details of our lives. He loved {food} and ");
            Console.WriteLine($"{animal} almost as much as I loved him. He offered to show me his {noun2} collection. ");
            Console.WriteLine("\n");
            Console.WriteLine($"For {number} days we talked and {verbed3}. The warm summer days turned {adj2} and he had to leave. ");
            Console.WriteLine($"I didn’t even get to say {salutation}. ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The End. ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();

            double cashApp = 18;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("If you enjoyed this game, please donate {0:C}+ to my CashApp: $LMcMcCall ", cashApp);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("\n");
        }
    }
}
