using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 'start' для создания 10 потоков:");
            string input = Console.ReadLine();
            if (input.ToLower() == "start")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Главный поток: {i}");
                    Thread newThread = new Thread(new ThreadStart(DoWork));
                    newThread.Start();
                    Thread.Sleep(300);
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread newThread = new Thread(new ThreadStart(DoWork));
                    newThread.Start();
                    Thread.Sleep(400);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите 'Start' для создания 10 потоков.");
            }

            Console.WriteLine("Введите 'continue' для создания еще 5 потоков или 'exit' для завершения программы:");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "continue")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Дополнительный поток: {i}");
                    Thread newThread = new Thread(new ThreadStart(Work));
                    newThread.Start();
                    Thread.Sleep(300);
                }
            }
            else if (input.ToLower() == "exit")
            {
                return;
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }
            Console.ReadLine();
        }

        static void Work()
        {
            Console.WriteLine("Выполнение работы в новом потоке...");
        }

        static void DoWork()
        {
            Console.WriteLine("Выполнение работы в новом потоке...");
        }


        

    }

}


