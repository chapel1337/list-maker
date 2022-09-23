using System;

// written by chapel1337
// finished on 8/19/2022
// i'll probably make another version of this once i learn how to read json files in c#

namespace list_maker
{
    class Program
    {
        public static string[] list = new string[100];
        public static int stepAmount = 0;
        static void Main(string[] args)
        {
            menu(false);
            pause();
        }

        public static int menu(bool ask)
        {
            if (ask == true)
            {
                newLine();

                Console.Write("would you like to see your list? ");
                string listAnswer = Console.ReadLine();

                if (listAnswer == "yes")
                {
                    getList();
                }
                else if (listAnswer == "no")
                {
                    menu(false);
                }
                else
                {
                    Console.WriteLine("please answer with yes or no");
                    menu(true);
                }
            }
            else if (ask == false)
            {
                newLine();

                Console.Write("input a step to be added to the list: ");
                appendStep(Console.ReadLine());
            }

            return 0;
        }

        public static int appendStep(string step)
        {
            if (stepAmount == 100)
            {
                Console.WriteLine("iosifghsdgf");
            }
            else
            {
                newLine();

                Console.WriteLine("added step to list");

                list[stepAmount] = step;
                stepAmount++;

                menu(true);
            }

            return 0;
        }

        public static int getList()
        {
            newLine();

            int stepNumber = 0;

            foreach (string i in list)
            {
                if (i != null)
                {
                    stepNumber++;
                    Console.WriteLine($"{stepNumber}. {i}");
                }
                else if (i == null)
                {
                    continue;
                }
            }

            menu(false);

            return 0;
        }

        static void pause()
        {
            Console.ReadKey();
        }

        static void newLine()
        {
            Console.WriteLine();
        }
    }
}
