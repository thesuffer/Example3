using System;
using System.Linq;

namespace Zadanie2
{
    class Program
    {
        static int Choice()
        {
            Console.WriteLine("\nВыберите действие:\nОдномерный массив:\n1.Найти максимальное число.\n2.Найти минимальное число.\n3.Найти сумму всех чисел.\n4.Найти среднеарифметитческое.\n5.Найти среднегеометрическое.\nДвумерный массив:\n6.Произведение матрицы на число.\n7.Транспонирование матрицы.\n8.Выход из программы.");

           int choice_enum = Convert.ToInt32(Console.ReadLine());

            return choice_enum;
        }

        static int Exit()
        {
            Console.WriteLine("Завершение программы...");
            Environment.Exit(0);
            return 0;
        }

        static int Cons ()
        {
            Console.WriteLine("Выполняется действтие...");
            return 0;
        }

        static void Max (ref int[] mas)
        {
          
            Console.WriteLine("Максимальное число = " + mas.Max());
        }

        static void Min(ref int[] mas)
        {

            Console.WriteLine("Минимальное число = " + mas.Min());
        }

        static void Sum(ref int[] mas)
        {
            Console.WriteLine("Сумма всех чисел = " + mas.Sum());
        }

        static void SrAr(ref double[] mas2)
        {
            Func<double, double, double> Sr = (x, y) => x/y;
            var result = Sr(mas2.Sum(), 10);
            Console.WriteLine("Среднеарифметичнеское = " + result);
        }

        static void SrG(ref double[] mas2)
        {
            Func<double, double, double> Sr = (x, y) => Math.Pow((x), y);
            var result = Sr(mas2.Sum(), 0.1);
            Console.WriteLine("Среднегеометрическое = " + result);
        }

        static void Matrix(ref double[,] array)
        {
            Console.WriteLine("Введите число, на которое хотите умножить матрицу: ");
            double k = Convert.ToDouble(Console.ReadLine());

            var resultArray = new double[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Func<double, double, double> res = (x, y) => x*y;
                    var result = res(array[i,j], k);
                    resultArray[i, j] = result;
                }
            }

            Console.WriteLine("Матрица, полученная в результате умножения на число " + k + " :");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(String.Format("{0,3}", resultArray[i, j]));
                    Console.WriteLine();
            }

        }

       
        static void Trans (ref double[,] array)
        {
            double[,] trans = new double[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    trans[i, j] = array[j, i];
                }
            }
            Console.WriteLine("Транспонированная матрица: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(String.Format("{0,3}", trans[i, j]));
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Приложение калькулятор ||");

            int[] mas = new int[10];

            Console.WriteLine("Введите числа одномерного массива, над которым будут выполнены операции:");

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("mas[" + i + "]=");
                mas[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write("Вы ввели:");

            for (int i = 0; i <= 9; i++)
            {
                Console.Write(mas[i] + "\t");
            }

            double[] mas2 = new double[10];

            Array.Copy(mas,mas2,10);

            Console.WriteLine("\nВведите числа двумерного массива, над которым будут выполнены операции:");

            double[,] array = new double[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("array[" + i + "," + j + "]: ");
                    array[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Вы ввели:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(String.Format("{0,3}", array[i, j]));
                Console.WriteLine();
            }

            while (true)
            {
               
                int choice_enum = Choice();

                int z = choice_enum == 8 ? Exit() : Cons();
                
                switch (choice_enum)
                {
                    case 1:
                        Max(ref mas);
                        break;
                    case 2:
                        Min(ref mas);
                        break;
                    case 3:
                        Sum(ref mas);
                        break;
                    case 4:
                        SrAr(ref mas2);
                        break;
                    case 5:
                        SrG(ref mas2);
                        break;
                    case 6:
                        Matrix(ref array);
                        break;
                    case 7:
                        Trans(ref array);
                        break;
                    default:
                        Console.WriteLine("Вы выбрали несуществующий вариант.");
                        break;
                }

                
            }
        }
    }
}
