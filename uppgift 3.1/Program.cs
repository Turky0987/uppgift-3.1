using System;

namespace TavlingsAlder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kontrollera din tävlingsålder");
            Console.Write("Ange din ålder: ");

            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Felaktig ålder. Ange ålder som ett heltal.");
            }
            else
            {
                switch (age)
                {
                    case int n when (n >= 16 && n <= 19):
                        Console.WriteLine("Du får delta i tävlingen!");
                        break;
                    case int n when (n < 16):
                        Console.WriteLine("Du är för ung för att delta i tävlingen.");
                        break;
                    default:
                        Console.WriteLine("Du är för gammal för att delta i tävlingen.");
                        break;
                }
            }

            Console.ReadKey(); 
        }
    }
}

