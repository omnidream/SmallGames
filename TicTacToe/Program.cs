using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLogo();
            PrintMenu();
        }

        public static void PrintLogo()
        {
            Console.WriteLine("");
            Console.WriteLine("████████ ██  ██████ ████████  █████   ██████ ████████  ██████  ███████ ");
            Console.WriteLine("   ██    ██ ██         ██    ██   ██ ██         ██    ██    ██ ██      ");
            Console.WriteLine("   ██    ██ ██         ██    ███████ ██         ██    ██    ██ █████   ");
            Console.WriteLine("   ██    ██ ██         ██    ██   ██ ██         ██    ██    ██ ██      ");
            Console.WriteLine("   ██    ██  ██████    ██    ██   ██  ██████    ██     ██████  ███████ ");
            Console.WriteLine("");
        }
        public static void PrintMenu()
        {
            Console.WriteLine("Spela Luffarschak mot en vän eller mot en mycket sofistikerad Ai ;-)");
            Console.WriteLine("Vill du spela mot någon eller mot datorn?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Spela mot datorn.");
            Console.WriteLine("2. Spela med en kompis.");
            Console.WriteLine("Välj alternativ 1 eller alternativ 2.");
            String userPlayMode = Console.ReadLine();
            if (ValidateIsNumber(userPlayMode))
                StartNewGame();
        }

        public static bool ValidateIsNumber(String userPlayMode)
        {
            if(Char.IsNumber(userPlayMode, 0) && userPlayMode.Length == 1)
                return true;
            else
            {
                Console.WriteLine("Felaktiv inmatning, försök igen.");
                PrintMenu();
                return false;
            }
        }

        public static void StartNewGame()
        {

        }
        
    }
}
