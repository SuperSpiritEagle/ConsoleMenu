using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string setName = "";
            int setPassword;

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Menu\n");
                Console.WriteLine($"1: Ввести имя\n2: ChangeConsoleColor\n3: Установить пароль\n4: Выход "); ;
                userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите ваше имя");
                        setName = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        int ChangeConsoleColor = random.Next(1, 5);
                        if (ChangeConsoleColor == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                        }
                        else if (ChangeConsoleColor == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Установите пароль");
                        setPassword = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Введите пароль");
                        int password = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (password == setPassword)
                        {
                            Console.WriteLine(setName);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
