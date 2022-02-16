using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassCSharpDZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 1");
                        Console.WriteLine("Написать программу, которая считывает символы с ");
                        Console.WriteLine("клавиатуры, пока не будет введена точка. Программа должна ");
                        Console.WriteLine("сосчитать количество введенных пользователем пробелов.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Введите некоторые символы ==> ");
                        char input;
                        int spaceCount = 0;
                        do
                        {
                            input = (char)Console.ReadKey();
                            if (input == ' ')
                                spaceCount++;
                        }
                        while (input != '.');
                        Console.WriteLine("Количество пробелов ==> " + spaceCount);
                    }
                    break;
                case '2':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 2");
                        Console.WriteLine("Числовые значения символов нижнего регистра в коде ASCII ");
                        Console.WriteLine("отличаются от значений символов верхнего регистра на величину ");
                        Console.WriteLine("32. Используя эту информацию, написать программу, которая ");
                        Console.WriteLine("считывает с клавиатуры и конвертирует все символы нижнего ");
                        Console.WriteLine("регистра в символы верхнего регистра и наоборот.");
                        Console.WriteLine("\n");
                        int e, count = 0;
                        char i;
                        for (; ; )
                        {
                            Console.WriteLine("Введите символ ==>");
                            e = Console.Read();
                            if (e >= 65 && e <= 90)
                            {
                                e += 32;
                                i = (char)e;
                                Console.WriteLine(i);

                            }
                            else if (e >= 97 && e <= 122)
                            {
                                e -= 32;
                                i = (char)e;
                                Console.WriteLine(i);
                            }
                            else if (e == 46)
                            {
                                break;
                            }
                            else
                            {
                                i = (char)e;
                                Console.WriteLine(i);
                            }
                            count++;
                        }
                        Console.WriteLine("Всего введено " + count + " символов");
                    }
                    break;
                case '3':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 3");
                        Console.WriteLine("Даны целые положительные числа A и B (A < B). Вывести все ");
                        Console.WriteLine("целые числа от A до B включительно; каждое число должно ");
                        Console.WriteLine("выводиться на новой строке; при этом каждое число должно ");
                        Console.WriteLine("выводиться количество раз, равное его значению. Например: если А ");
                        Console.WriteLine("= 3, а В = 7, то программа должна сформировать в консоли ");
                        Console.WriteLine("следующий вывод:");
                        Console.WriteLine("3 3 3");
                        Console.WriteLine("4 4 4 4");
                        Console.WriteLine("5 5 5 5 5");
                        Console.WriteLine("6 6 6 6 6 6");
                        Console.WriteLine("7 7 7 7 7 7 7");
                        Console.WriteLine("\n");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 1; i <= a; i++)
                            Console.Write("{0}", a);
                        while (a < b)
                        {
                            a += 1;
                            Console.WriteLine();
                            for (int i = 1; i <= a; i++)
                                Console.Write("{0}", a);
                        }
                        break;
                    }
            }
        }
    }
    }
