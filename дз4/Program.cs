using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз4
{
    internal class Program
    {
        static void PrintArray(int[] array)//для первого задания
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void FirstTask()
        {
            /*Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            которые нужно поменять местами. Вывести на экран получившийся массив.*/
            
            Console.WriteLine("задание 1");
            
            Random random = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(101);
            }
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);
            Console.WriteLine("Введите первое число для замены:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число для замеены:");
            int secondNumber = int.Parse(Console.ReadLine());
            int index1 = Array.IndexOf(numbers, firstNumber);
            int index2 = Array.IndexOf(numbers, secondNumber);
            if (index1 == -1 || index2 == -1)
            {
                Console.WriteLine("Одно или оба числа не найдены в массиве");
            }
            else
            {
                int temp = numbers[index1];
                numbers[index1] = numbers[index2];
                numbers[index2] = temp;
                Console.WriteLine("Изменённый массив:");
                PrintArray(numbers);
            }
        }
        static int Calculations(int[] numbers, ref int product, out double arithmeticAverage)//для второго
        {
            int sum = 0;
            product = 1; 
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }
            arithmeticAverage = (numbers.Length > 0) ? (double)sum / numbers.Length : 0;
            return sum;
        }
        static void SecondTask()
        {
            /*Написать метод, где в качества аргумента будет передан массив (ключевое слово
            params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение
            массива. Вывести (out) среднее арифметическое в массиве*/
            
            Console.WriteLine("задание 2");

            int[] numbers = { 2, 6, 8, 10, 14};
            int product = 1; 
            int sum = Calculations(numbers, ref product, out double arithmeticAverage);
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Произведение элементов массива: {product}");
            Console.WriteLine($"Среднее арифметическое: {arithmeticAverage}");
        }
        static void Main(string[] args)
        {
           FirstTask();
           SecondTask();
        }
    }
}
