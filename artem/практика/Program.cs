namespace Sweqlory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите номер задания: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10  \n ");
                int choose = Convert.ToInt32(Console.ReadLine());

                //задание 1
                if (choose == 1)
                {
                    Console.Write("Задание 1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними. \n");

                    Console.Write("Введите 1 число :");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите 2 число :");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите 3 число :");
                    double num3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите 4 число :");
                    double num4 = Convert.ToDouble(Console.ReadLine());

                    double averge = (num1 + num2 + num3 + num4) / 4;

                    Console.WriteLine($"Среднее значение чисел : {averge}");

                    Console.WriteLine("Задание 1 закончено, нажмите на любую клавишу, чтобы вернуться к списку задач");
                }
                if (choose ==2)
                //задание 2
                {
                    Console.Write("Задание 2: Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел.  \n");

                    Console.Write("Введите 1 число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите 2 число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1) Сложение(+)");
                    Console.WriteLine("2) Вычитание(-)");
                    Console.WriteLine("3) Умножение(*)");
                    Console.WriteLine("4) Деление(/)");
                    Console.WriteLine("5) Остаток(%)");

                    Console.WriteLine("Введите номер операции");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    double result;

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine($"Результат: {result}");
                            break;
                        case 2:
                            result = num2 - num1;
                            Console.WriteLine($"Результат: {result}");
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine($"Результат: {result}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Результат: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, деление на ноль невозможно");
                            }
                            break;
                        case 5:
                            if (num2 != 0)
                            {
                                result = num1 % num2;
                                Console.WriteLine($"Результат: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, деление на ноль невозможно");
                            }
                            break;

                        default:
                            Console.WriteLine("Выбранo некорректное действие! ");
                            break;
                    }
                    Console.WriteLine("Задание 2 закончено, нажмите на любую клавишу, чтобы вернуться к списку задач");
                   


                }
                //3 задание

                if (choose == 3)
                {
                    Console.Write("Задание 3: Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта. ");
                    Console.WriteLine("Выберите тип:");
                    Console.WriteLine("1. Цельсии в Кельвины");
                    Console.WriteLine("2. Цельсии в Фаренгейты");
                    Console.WriteLine("3. Кельвины в Цельсии");
                    Console.WriteLine("4. Кельвины в Фаренгейты");
                    Console.WriteLine("5. Фаренгейты в Цельсии");
                    Console.WriteLine("6. Фаренгейты в Кельвины");

                    Console.Write("Введите пожалуйста выбранный вами номер!)");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= 6)
                    {
                        Console.Write("Введите температуру:");
                        double temp = Convert.ToDouble(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"{temp} °C = {CelsiusToKelvin(temp)} °K");
                                break;
                            case 2:
                                Console.WriteLine($"{temp} °C = {CelsiusToFahrenheit(temp)} °F");
                                break;
                            case 3:
                                Console.WriteLine($"{temp} °C = {KelvinToFahrenheit(temp)} °F");
                                break;
                            case 4:
                                Console.WriteLine($"{temp} °C = {KelvinToCelsius(temp)} °C ");
                                break;
                            case 5:
                                Console.WriteLine($"{temp} °C = {FahrenheitToCelsius(temp)} °C ");
                                break;
                            case 6:
                                Console.WriteLine($"{temp} °C = {FahrenheitToKelvin(temp)} °K");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверно выбрано!");
                    }

                }
                static double CelsiusToKelvin(double celsius)
                {
                    return celsius + 273.15;
                }

                static double CelsiusToFahrenheit(double celsius)
                {
                    return (celsius * 9 / 5) + 32;
                }

                static double KelvinToCelsius(double kelvin)
                {
                    return kelvin - 273.15;
                }

                static double KelvinToFahrenheit(double kelvin)
                {
                    return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
                }

                static double FahrenheitToCelsius(double fahrenheit)
                {
                    return (fahrenheit - 32) * 5 / 9;
                }

                static double FahrenheitToKelvin(double fahrenheit)
                {
                    return CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
                }
                

                


                //4 задание

                if (choose == 4)
                {
                    Console.Write("Задание 4: Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути\n .");
                    Console.WriteLine("Введите путь");
                    string str = Console.ReadLine();
                    string[] parts = str.Split('/');
                    Console.WriteLine(parts[parts.Length - 1]);

                    Console.WriteLine(" Задание 4 закончено, нажмите на любую клавишу");
                }


                //5 задание

                if (choose == 5)
                {
                    Console.Write(" Задание 5: Разработайте программу для нахождения самого длинного слова в предложении.");
                    Console.WriteLine(" Введите предложение : ");
                    string input = Console.ReadLine();

                    string[] words = input.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    string longestWord = "";

                    foreach (string word in words)
                    {
                        if (word.Length > longestWord.Length)
                        {
                            longestWord = word;
                        }
                    }

                    if (longestWord.Length > 0)
                    {
                        Console.WriteLine($" Самое длинное слово : {longestWord} (длина : {longestWord.Length})");
                    }
                    else
                    {
                        Console.WriteLine(" Нет слов ");
                    }
                    Console.WriteLine(" Задание 5 закончено , нажмите на любую клавишу");

                }
                //6 задание

                if (choose == 6)
                {
                    Console.Write("Задание 6: Разработайте программу, которая может перемножить два массива значений");
                    Console.WriteLine(" Элементы первого массива : ");
                    string[] input1 = Console.ReadLine().Split(' ');
                    int[] array1 = Array.ConvertAll(input1, int.Parse);

                    Console.WriteLine(" Элементы второго массива : ");
                    string[] input2 = Console.ReadLine().Split(' ');
                    int[] array2 = Array.ConvertAll(input1, int.Parse);

                    if (array1.Length != array2.Length)
                    {
                        Console.WriteLine(" Ошибка.");
                        return;
                    }

                    int[] resultArray = new int[array1.Length];

                    for (int i = 0; i < array1.Length; i++)
                    {
                        resultArray[i] = array1[i] * array2[i];
                    }
                    Console.WriteLine(" Результат : ");
                    Console.WriteLine(string.Join(", ", resultArray));
                    Console.WriteLine(" Задание 6 закончено, нажмите на любую клавишу");
                }
                //7 Задание

                if (choose == 7)
                {
                    Console.Write("Задание 7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных. ");
                    double[] numbers = new double[5];

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($" Введите число {i + 1} : ");
                        numbers[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    double maximum = numbers[0];
                    double minimum = numbers[0];

                    foreach (double number in numbers)
                    {
                        if (number > maximum)
                        {
                            maximum = number;
                        }

                        if (number < minimum)
                        {
                            minimum = number;
                        }



                    }

                    Console.WriteLine($" Максимальное число : {maximum}");
                    Console.WriteLine($" Максимальное число : {minimum}");

                    Console.WriteLine(" Задание 7 закончено , нажмите на любую клавишу");

                }
                //8 задание
                if (choose == 8)
                {
                    Console.Write("Задание 8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем.");
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


                        Console.WriteLine(" Задание 8 закончено , нажмите на любую клавишу");
                    }
                }
                //9 задание

                if (choose == 9)
                {
                    Console.Write("Задание 9: Напечатать полную таблицу умножения");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.Write($"{1} x {j} = {i * j}\t");
                        }

                        Console.WriteLine();

                        Console.WriteLine(" Задание 9 закончено, нажмите на любую клавишу");

                    }


                }
            }




        }
        
    }
}
