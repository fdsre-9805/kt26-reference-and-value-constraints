using System;

namespace BoxesApp
{
    class Program
    {
        static void Main()
        {
            ReferenceBox<string> nameBox = new ReferenceBox<string>();
            Console.WriteLine("ReferenceBox<string> создан");
            Console.WriteLine($"IsEmpty: {nameBox.IsEmpty}");

            nameBox.Set(ReadText("Введите имя: "));
            Console.WriteLine($"IsEmpty: {nameBox.IsEmpty}");
            Console.WriteLine($"Get(): {nameBox.Get()}");

            Console.WriteLine();
            ValueBox<int> ageBox = new ValueBox<int>();
            Console.WriteLine("ValueBox<int> создан");
            Console.WriteLine($"IsEmpty: {ageBox.IsEmpty}");

            ageBox.Set(ReadNumber("Введите возраст: "));
            Console.WriteLine($"IsEmpty: {ageBox.IsEmpty}");
            Console.WriteLine($"Get(): {ageBox.Get()}");
        }

        static string ReadText(string prompt)
        {
            Console.Write(prompt);
            string text = Console.ReadLine()!;
            while (text == "")
            {
                Console.Write("Строка не должна быть пустой: ");
                text = Console.ReadLine()!;
            }
            return text;
        }

        static int ReadNumber(string prompt)
        {
            Console.Write(prompt);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Нужно целое число: ");
            }
            return number;
        }
    }
}
