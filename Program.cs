using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Это Лабораторная Работа №1 Артема Гилева(ИТ-10)");

            while (true)
            {
                Console.WriteLine("Введите номер задания, 0 для выхода");
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: N1(); break;
                    case 2: N2(); break;
                    case 3: N3(); break;
                    case 4: N4(); break;
                    case 0: return;
                    default: Console.WriteLine("Неверный номер задания"); break;
                }
            }
        }

        static void N1()
        {
            Console.WriteLine("Введите номер задачи, выбрав из следующих: 1, 3, 5, 7, 9");
            string s = Console.ReadLine();
            LAB1N1 lab1 = new LAB1N1();

            switch (Convert.ToInt32(s))
            {
                case 1:
                    Console.WriteLine("Введите число");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Дробная часть введённого числа: " + lab1.Fraction(x1));
                    break;

                case 3:
                    Console.WriteLine("Введите цифру");
                    char x3 = Console.ReadLine()[0];
                    if (char.IsDigit(x3))
                        Console.WriteLine("Перевод введённого char в int: " + lab1.CharToNum(x3));
                    else
                        Console.WriteLine("Неверно введено значение");
                    break;

                case 5:
                    Console.WriteLine("Введите целое число");
                    int x5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lab1.Is2Digits(x5) ?
                        $"Число {x5} является двузначным" :
                        $"Число {x5} НЕ является двузначным");
                    break;

                case 7:
                    Console.WriteLine("Введите первую границу");
                    int a7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите вторую границу");
                    int b7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число для проверки");
                    int num7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(lab1.IsInRange(a7, b7, num7) ?
                        $"Число {num7} лежит в промежутке между {a7} и {b7}" :
                        $"Число {num7} НЕ лежит в промежутке между {a7} и {b7}");
                    break;

                case 9:
                    Console.WriteLine("Введите первое число");
                    int a9 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int b9 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    int c9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(lab1.IsEqual(a9, b9, c9) ?
                        $"Числа {a9}, {b9} и {c9} являются равными" :
                        $"Числа {a9}, {b9} и {c9} НЕ являются равными");
                    break;

                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }

        static void N2()
        {
            Console.WriteLine("Введите номер задачи, выбрав из следующих: 1, 3, 5, 7, 9");
            string s = Console.ReadLine();
            LAB1N2 lab2 = new LAB1N2();

            switch (Convert.ToInt32(s))
            {
                case 1:
                    Console.WriteLine("Введите число");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Модуль введённого числа: " + lab2.Abs(x1));
                    break;

                case 3:
                    Console.WriteLine("Введите число для проверки");
                    int x3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lab2.Is35(x3) ?
                        "Число делится либо на 3, либо на 5" :
                        "Число не делится на 3 и на 5, либо делится на 15");
                    break;

                case 5:
                    Console.WriteLine("Введите первое число");
                    int a5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int b5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    int c5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Наибольшее число - " + lab2.Max3(a5, b5, c5));
                    break;

                case 7:
                    Console.WriteLine("Введите первое число");
                    int a7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int b7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма данных чисел (с учётом условия задачи) равна " + lab2.Sum2(a7, b7));
                    break;

                case 9:
                    Console.WriteLine("Введите номер дня недели");
                    int x9 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lab2.Day(x9));
                    break;

                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }

        static void N3()
        {
            Console.WriteLine("Введите номер задачи, выбрав из следующих: 1, 3, 5, 7, 9");
            string s = Console.ReadLine();
            LAB1N3 lab3 = new LAB1N3();

            switch (Convert.ToInt32(s))
            {
                case 1:
                    Console.WriteLine("Введите число");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Числа от 0 до числа: " + lab3.ListNums(x1));
                    break;

                case 3:
                    Console.WriteLine("Введите число");
                    int x3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Чётные числа от 0 до числа: " + lab3.Chet(x3));
                    break;

                case 5:
                    Console.WriteLine("Введите число");
                    long x5 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Количество знаков в {x5} = {lab3.NumLen(x5)}");
                    break;

                case 7:
                    Console.WriteLine("Введите размер квадрата");
                    int x7 = Convert.ToInt32(Console.ReadLine());
                    lab3.Square(x7);
                    break;

                case 9:
                    Console.WriteLine("Введите размер треугольника");
                    int x9 = Convert.ToInt32(Console.ReadLine());
                    lab3.RightTriangle(x9);
                    break;

                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }

        static void N4()
        {
            Console.WriteLine("Введите номер задачи, выбрав из следующих: 1, 3, 5, 7, 9");
            string s = Console.ReadLine();
            LAB1N4 lab4 = new LAB1N4();

            switch (Convert.ToInt32(s))
            {
                case 1:
                    Console.WriteLine("Введите длину массива");
                    int len1 = Convert.ToInt32(Console.ReadLine());
                    if (len1 <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr1 = new int[len1];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < len1; i++)
                        arr1[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите искомое число");
                    int x1 = Convert.ToInt32(Console.ReadLine());

                    int pos = lab4.FindFirst(arr1, x1);
                    Console.WriteLine(pos >= 0 ?
                        $"Позиция вхождения x в массив: {pos}" :
                        "Элемент не найден");
                    break;

                case 3:
                    Console.WriteLine("Введите длину массива");
                    int len3 = Convert.ToInt32(Console.ReadLine());
                    if (len3 <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr3 = new int[len3];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < len3; i++)
                        arr3[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Наибольшее число в массиве по модулю: " + lab4.MaxAbs(arr3));
                    break;

                case 5:
                    Console.WriteLine("Введите длину первого массива");
                    int len5a = Convert.ToInt32(Console.ReadLine());
                    if (len5a <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr5a = new int[len5a];
                    Console.WriteLine("Введите элементы первого массива:");
                    for (int i = 0; i < len5a; i++)
                        arr5a[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите длину второго массива");
                    int len5b = Convert.ToInt32(Console.ReadLine());
                    if (len5b <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr5b = new int[len5b];
                    Console.WriteLine("Введите элементы второго массива:");
                    for (int i = 0; i < len5b; i++)
                        arr5b[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите позицию вставки");
                    int pos5 = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        int[] result5 = lab4.Add(arr5a, arr5b, pos5);
                        Console.WriteLine("Результат вставки массива в массив:");
                        foreach (int num in result5)
                            Console.Write(num + "\t");
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 7:
                    Console.WriteLine("Введите длину массива");
                    int len7 = Convert.ToInt32(Console.ReadLine());
                    if (len7 <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr7 = new int[len7];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < len7; i++)
                        arr7[i] = Convert.ToInt32(Console.ReadLine());

                    int[] result7 = lab4.ReverseBack(arr7);
                    Console.WriteLine("Результат переворота массива:");
                    foreach (int num in result7)
                        Console.Write(num + "\t");
                    Console.WriteLine();
                    break;

                case 9:
                    Console.WriteLine("Введите длину массива");
                    int len9 = Convert.ToInt32(Console.ReadLine());
                    if (len9 <= 0)
                    {
                        Console.WriteLine("Длина массива должна быть больше 0");
                        break;
                    }

                    int[] arr9 = new int[len9];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < len9; i++)
                        arr9[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите искомое число");
                    int x9 = Convert.ToInt32(Console.ReadLine());

                    int[] result9 = lab4.FindAll(arr9, x9);
                    Console.WriteLine($"Индексы всех вхождений числа {x9} в массив:");
                    foreach (int index in result9)
                        Console.Write(index + "\t");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }
    