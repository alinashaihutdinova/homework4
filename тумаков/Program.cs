using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков
{
    internal class Program
    {
        static int GetMax(int a, int b)//для первого задания
        {
            return (a > b) ? a : b; 
        }
        static void FirstTask()
        {
            /*Написать метод, возвращающий наибольшее из двух чисел. Входные
             параметры метода– два целых числа. Протестировать метод*/
            
            Console.WriteLine("Упражнение 5.1");
            
            Console.WriteLine("Введите первое число для вычисления наибольшего значения:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMax(firstNumber, secondNumber);
            Console.WriteLine($"Наибольшее из двух чисел: {maxNumber}");
        }
        static void Swap(ref int a, ref int b)//для второго задания
        {
            int temp = a; //временная переменная
            a = b;
            b = temp; 
        }
        static void SecondTask()
        {
            /*Написать метод, который меняет местами значения двух передаваемых
            параметров. Параметры передавать по ссылке. Протестировать метод.*/
            
            Console.WriteLine("Упражнение 5.2");
            
            Console.WriteLine("Введите первое число для изменения значений местами с другим числом:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int secondValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"До обмена: первое значение = {firstValue}, второе значение = {secondValue}");
            Swap(ref firstValue, ref secondValue); // обмен значениями
            Console.WriteLine($"После обмена: первое значение = {firstValue}, второе значение = {secondValue}");
        }
        static bool CalculateFactorial(int n, out long result)//для третьего
        {
            result = 1; 
            if (n < 0)
            {
                result = 0; 
                return false;
            }
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    result = checked(result * i);
                }
                return true; 
            }
            catch (OverflowException)
            {
                return false; 
            }
            finally
            {
                Console.WriteLine("Спасибо за использование программы");
            }
        }
        static void ThirdTask()
        { 
            /*Написать метод вычисления факториала числа, результат вычислений
            передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            если в процессе вычисления возникло переполнение, то вернуть значение false. Для
            отслеживания переполнения значения использовать блок checked*/
            
            Console.WriteLine("Упражнение 5.3");

            Console.WriteLine("Введите натуральное число для вычисления факториала: ");
            int number = int.Parse(Console.ReadLine());
            if (CalculateFactorial(number, out long factorialResult))
            {
                Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
            }
            else
            {
                Console.WriteLine($"Произошло переполнение при вычислении факториала числа {number}");
            }
        }

        static long RecursiveFactorial(int n)//для четвертого
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = checked(n * RecursiveFactorial(n - 1));
            return result;
        }
        static void FourthTask()
        {
            /*Написать рекурсивный метод вычисления факториала числа.*/
           
            Console.WriteLine("Упражнение 5.4");

            Console.WriteLine("Введите натуральное число для вычисления факториала");
            int number = int.Parse(Console.ReadLine());
            try
            {
                long factorialResult = RecursiveFactorial(number);
                Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Произошло переполнение при вычислении факториала числа {number}");
            }
            finally
            {
                Console.WriteLine("Спасибо за использование программы");
            }
        }

        static int GCD(int a, int b)//для пятого
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b; 
                a = temp;  
            }
            return a; 
        }
        static int GCD(int a, int b, int c)
        {
            return GCD(GCD(a, b), c); 
        }
        static void FifthTask()
        {
            /*Написать метод, который вычисляет НОД двух натуральных чисел
            (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
            натуральных чисел*/
           
            Console.WriteLine("Домашнее задание 5.1");

            Console.WriteLine("Введите первое натуральное число для вычисления НОД: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе натуральное число: ");
            int num2 = int.Parse(Console.ReadLine());
            int gcd2 = GCD(num1, num2);
            Console.WriteLine($"НОД чисел {num1} и {num2} равен {gcd2}");
            Console.WriteLine("Введите третье натуральное число: ");
            int num3 = int.Parse(Console.ReadLine());
            int gcd3 = GCD(num1, num2, num3);
            Console.WriteLine($"НОД чисел {num1}, {num2} и {num3} равен {gcd3}");
        }
        static long Fibonacci(int n)//для шестого
        {
            if (n == 1 || n == 2)
            {
                return 1; // тк первые два числа фибоначчи равны 1
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void SixthTask()
        {
            /*Написать рекурсивный метод, вычисляющий значение n-го числа
            ряда Фибоначчи. Ряд Фибоначчи– последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
            13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 */
            
            Console.WriteLine("Домашнее задание 5.2");

            Console.WriteLine("Введите номер числа Фибоначчи:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Пожалуйста, введите положительное число");
            }
            else
            {
                long fibonacciResult = Fibonacci(n);
                Console.WriteLine($"Число Фибоначчи {n} равно {fibonacciResult}");
            }
        }
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
        }
    }
}
