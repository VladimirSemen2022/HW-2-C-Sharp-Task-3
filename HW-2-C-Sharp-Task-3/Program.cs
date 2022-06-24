//Задание 3
//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
//Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
//символом, находящимся на некотором постоянном числе позиций левее или правее него в алфавите. Например,
//в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее.
//Кроме механизма шифровки, реализуйте механизм расшифрования.

using System;

namespace HW_2_C_Sharp_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any text on English");
            string inputText = Console.ReadLine();
            int shift = 10;          //Задание позиции смещения символа относительно первоначального кода в ASCII
            string newText = inputText;
            for (int i = 122; i >= 65; i--)
                newText = newText.Replace(Convert.ToChar(i), Convert.ToChar(i + shift));
            for (int i = 122; i < 122 + shift; i++)
                newText = newText.Replace(Convert.ToChar(i), Convert.ToChar(65 + i - 122));
            Console.WriteLine("\n\nYour text after convert into Caesar's code");
            Console.WriteLine(newText);
            Console.WriteLine("\n\nYou want to convert this Caesar's code back into your text Y/(N or Any)?");
            if (Console.ReadKey().Key != ConsoleKey.Y)
                return;
            else
            {
                for (int i = 65; i < 65 + shift; i++)
                    newText = newText.Replace(Convert.ToChar(i), Convert.ToChar(122 + i - 65));
                for (int i = 65; i <= 122 + shift; i++)
                    newText = newText.Replace(Convert.ToChar(i), Convert.ToChar(i - shift));
            }
            Console.WriteLine("\n\nYour text after convert from  Caesar's code");
            Console.WriteLine(newText);
        }
    }
}
