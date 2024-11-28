using System.ComponentModel.Design;

namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput, systemInput;
            int r;
            Console.WriteLine("Was möchstest du aussuche?\n\n Stein / Papier / Schere? ");
            userInput = Console.ReadLine().ToLower();
            Random rnd = new Random();
            r = rnd.Next(1, 4);
            switch (r)
            {
                case 1:
                    systemInput = "Stein";
                    Console.WriteLine("Computer hat Stein gewählt");
                    if (userInput == "Stein")
                    {
                        Console.WriteLine("\nThis is a draw");

                    }
                    else if (userInput == "papier")
                    {
                        Console.WriteLine("\nDU hast gewonnen!");
                    }
                    else
                    {
                        Console.WriteLine("\nDu hast verloren!");
                    }
                    break;

                case 2:
                    systemInput = "papier";
                    Console.WriteLine("Computer hat Papier ausgewählt!");
                    if (userInput == "stein")
                    {
                        Console.WriteLine("\nDu hast verloren");
                    }
                    else if (userInput == "papier")
                    {
                        Console.WriteLine("\nIt is a Draw!");

                    }
                    else
                    {
                        Console.WriteLine("\nDu hast geweonnen");

                    }
                    break;
                case 3:
                    systemInput = "schere";
                    Console.WriteLine("Computer hat Schere gewählt");
                    if (userInput == "stein")
                    {
                        Console.WriteLine("\nDu hast gewonnen");
                    }
                    else if (userInput == "papier")
                    {
                        Console.WriteLine("\n Du hast verloren!");
                    }
                    else
                    {
                        Console.WriteLine("\nIt is a draw");
                    }
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;



            }
        }
    }
}
