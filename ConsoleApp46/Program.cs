using System.Diagnostics.Metrics;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandCloseProgram = "exit";
            string userInput;

            while (true)
            {
                Console.WriteLine("Введите команду - " + "\"" + commandCloseProgram + "\"" + " для закрытия программы.");
                userInput = Console.ReadLine();

                if (userInput == commandCloseProgram)
                {
                    break;
                }
                else if (userInput != commandCloseProgram)
                {
                    Console.WriteLine("Попробуйте снова.");
                }
            }
        }
    }
}