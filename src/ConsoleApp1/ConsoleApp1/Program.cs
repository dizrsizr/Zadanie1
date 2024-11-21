using System;
using System.Collections.Generic;
using System.Linq;

namespace Задание1
{
    internal class Задание1
    {
        static void Main(string[] args)
        {
            int aaaaa = 1;
            while (aaaaa == 1)
            {
                Console.WriteLine("1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
                Console.WriteLine("2: Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
                Console.WriteLine("3: Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
                Console.WriteLine("4: Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
                Console.WriteLine("5: Разработайте программу для нахождения самого длинного слова в предложении");
                Console.WriteLine("6: Разработайте программу, которая может перемножить два массива значений");
                Console.WriteLine("7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
                Console.WriteLine("8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
                Console.WriteLine("9: Напечатать полную таблицу умножения");
                Console.WriteLine("10: Разработайте программу, которая на основе выбранного действия выполняет");
                Console.WriteLine("0 - Завершить программу");
                int window = Convert.ToInt32(Console.ReadLine());
                switch (window)
                {
                    case 1:
                        double n1, n2, n3, n4;
                        double average, result;
                        Console.WriteLine("1:");
                        Console.WriteLine("1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
                        Console.WriteLine("Введите первое число");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите третье число");
                        n3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите четвёртое число");
                        n4 = Convert.ToDouble(Console.ReadLine());
                        average = (n1 + n2 + n3 + n4) / 4;
                        Console.WriteLine("Среднее значение чисел " + n1 + ", " + n2 + ", " + n3 + ", " + n4 + " равно: " + average);
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("2:");
                        Console.WriteLine("Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
                        Console.WriteLine("Введите первое число:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Выберите выполняемое действие: \n" +
                            "1. Сложение\n" +
                            "2. Вычитание\n" +
                            "3. Умножение\n" +
                            "4. Деление\n" +
                            "5. Нахождение остатка\n");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                result = n1 + n2;
                                Console.WriteLine("Результат " + n1 + " + " + n2 + " = " + result);
                                break;
                            case "2":
                                result = n1 - n2;
                                Console.WriteLine("Результат " + n1 + " - " + n2 + " = " + result);
                                break;
                            case "3":
                                result = n1 * n2;
                                Console.WriteLine("Результат " + n1 + " * " + n2 + " = " + result);
                                break;
                            case "4":
                                result = n1 / n2;
                                Console.WriteLine("Результат " + n1 + " / " + n2 + " = " + result);
                                break;
                            case "5":
                                result = n1 % n2;
                                Console.WriteLine("Результат " + n1 + " % " + n2 + " = " + result);
                                break;
                            default:
                                Console.WriteLine("Ошибка ввода");
                                break;
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        int inputsys, countsys;
                        Console.WriteLine("3:");
                        Console.WriteLine("Выберете шкалу вводимой температуры: \n" +
                        "1: Цельсий \n" +
                        "2: Кельвин \n" +
                        "3: Фаренгейт \n");
                        inputsys = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите показатель температуры(градусы): ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Выберите тип шкалы для конвертации: \n" +
            "1. Цельсий\n" +
            "2. Кельвин\n" +
            "3. Фаренгейт\n");
                        countsys = Convert.ToInt32(Console.ReadLine());
                        switch (inputsys)
                        {
                            case 1:
                                switch (countsys)
                                {
                                    case 1:
                                        Console.WriteLine("Вы зачем-то переводите Цельсий в Цельсий???");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Цельсий -> Кельвин");
                                        result = n1 + 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Цельсий -> Фаренгейт");
                                        result = (n1 * 9 / 5) + 32;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            case 2:
                                switch (countsys)
                                {
                                    case 1:
                                        Console.WriteLine("Вы выбрали: Кельвин в Цельсий");
                                        result = n1 - 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Кельвин -> Кельвин");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Кельвин -> Фаренгейт");
                                        result = (n1 - 273.15) * 9 / 5 + 32;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            case 3:
                                switch (countsys)
                                {
                                    case 1:
                                        Console.WriteLine("Вы выбрали: Фаренгейт в Цельсий");
                                        result = (n1 - 32) * 5 / 9;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 2:
                                        Console.WriteLine("Вы выбрали: Фаренгейт -> Кельвин");
                                        result = (n1 - 32) * 5 / 9 + 273.15;
                                        Console.WriteLine("Результат конвертации: " + result);
                                        break;
                                    case 3:
                                        Console.WriteLine("Вы выбрали: Фаренгейт -> Фаренгейт");
                                        Console.WriteLine("Результат конвертации: " + n1);
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка ввода");
                                break;
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("4:");
                        Console.WriteLine("Введите путь до файла: ");
                        string input = Console.ReadLine();
                        string[] subs = input.Split('\\');
                        int a = subs.Length;
                        Console.WriteLine(subs[a - 1]);
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("5: Введите строку: ");
                        input = Console.ReadLine();
                        string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' });
                        int maxlen = 0;
                        int index = 0;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i].Length > maxlen)
                            {
                                maxlen = str[i].Length;
                                index = i;
                            }
                        }
                        Console.Write("Самое длинное слово: {0}", str[index]);
                        Console.ReadLine();
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("6: Введите значения для первого массива через пробел:");
                        string arr1 = Console.ReadLine();
                        string[] firstArrey = arr1.Split(' ');
                        Console.WriteLine("Введите значения для второго массива через пробел:");
                        arr1 = Console.ReadLine();
                        string[] secondArrey = arr1.Split(' ');
                        for (int i = 0; i < firstArrey.Length; i++)
                        {
                            Console.Write($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Write("7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных\n");
                        Console.WriteLine("Введите пять чисел:");
                        string arr = Console.ReadLine(); // Определение переменной arr
                        string[] partse = arr.Split(" ");
                        int suMax = -999999999;
                        int suMin = 999999999;
                        foreach (string i in partse)
                        {
                            if (suMax < Convert.ToInt32(i))
                            {
                                suMax = Convert.ToInt32(i);
                            }
                            if (suMin > Convert.ToInt32(i))
                            {
                                suMin = Convert.ToInt32(i);
                            }
                        }
                        Console.WriteLine("Максимальное число: " + suMax); Console.WriteLine("Минимальное число: " + suMin);
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Write("8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем\n");
                        Console.Write(" Введите уровень пирамиды : ");
                        int levels = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= levels; i++)
                        {
                            for (int j = 0; j < levels - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write(k + " ");
                            }


                            Console.WriteLine();
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Write("9: Напечатать полную таблицу умножения в виде\n");
                        for (int i = 1; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.Write($"{i} x {j} = {i * j}\t");
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 10:
                        List<int> listA = new List<int> { -1, 2, -3, 4, 5, 6, 12 };

                        // 1. Найдите сумму положительных элементов этого списка.
                        int sumPositive = listA.Where(x => x > 0).Sum();
                        Console.WriteLine("Сумма положительных элементов: " + sumPositive);

                        // 2. Найдите сумму тех элементов этого списка, которые больше единицы и меньше десяти.
                        int sumBetweenOneAndTen = listA.Where(x => x > 1 && x < 10).Sum();
                        Console.WriteLine("Сумма элементов между 1 и 10: " + sumBetweenOneAndTen);

                        // 3. Найдите сумму элементов этого списка.
                        int totalSum = listA.Sum();
                        Console.WriteLine("Общая сумма элементов: " + totalSum);

                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        aaaaa = 0;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}