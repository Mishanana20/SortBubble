///Сортировка пузырьком
///передаем в функцию массив конечной длины и на выходе получаем отсортированный
///Сортировка устойчивая и сложность равна O(n^2)
///Для понимания и реализации этот алгоритм — простейший, но эффективен он лишь для небольших массивов. 
///чисто учебный алгоритм сортировки. Практически не применяется на практике
///Cложность алгоритма: O(n^{2}).
///
///
///Суть: Каждый проход элементы сравниваются попарно. если элемент больше следующего, то
///они меняются местами. дальше сранивается следующая пара этого элемента
///и после каждого пробега записываем значение в новый массив

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Kvadra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100000];
            for (int i = 99999; i >= 0; i--)
            {
                array[i] = 100 - i;
            }

            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();
            //List<int> sortedList = BubbleSort(array).ToList();
            int[] sortedList = BubbleSort(array);
            stopwatch.Stop();
            //смотрим сколько миллисекунд было затрачено на выполнение
            Console.WriteLine("Время выполнения {0}", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            sortedList = null;
            Console.ReadLine();
        }

        static int[] BubbleSort(int[] intArray)
        {
            int tempInt;
            for (int i = 0; i < intArray.Length; i++) //для все  длины  массива
            {
                for (int j = i + 1; j < intArray.Length; j++) //проходимся по массиву 
                {
                    if (intArray[i] > intArray[j]) //если левое число больше правого - меняем их местами
                    {
                        tempInt = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = tempInt;
                    }
                }
            }
            return intArray;
        }
    }
}