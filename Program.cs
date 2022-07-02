/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.

**Примеры**:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOutputArray = 0;  // задание переменной при инициализации проекта
            int maxLenght = 3; // максимальная длинна строки для выборки
            string[] inputArray = { "hello", "2", "world", ":-)" };  // первый пример для выборки
            //string[] inputArray = {"1234", "1567", "-2", "computer science"};  // второй пример для выборки
            //string[] inputArray = {"Russia", "Denmark", "Kazan"}; // третий пример для выборки
            PrintArray(inputArray);
            Console.Write(" -> ");
            string[] tempArray = new string[inputArray.Length];
            tempArray = SelectFromArray(inputArray, maxLenght);  // производим выборку во временный массив той же длинны, что и входящий массив
            string[] outputArray = new string[sizeOutputArray];  // создаем результирующий массив необходимой длинны (кол-во значений мы определили при селекции во временный массив)
            outputArray = TruncateArray(tempArray, sizeOutputArray);  // приобразуем временный массив в результирующий путем обрезании пустых элементов
            PrintArray(outputArray);


            string[] SelectFromArray(string[] inputArray, int length) // выборка в результирующий массив где length - максимальная длинна строки для выборки
            {
                string[] tempArray = new string[inputArray.Length];
                int j = 0;
                foreach (var item in inputArray)
                {
                    if (item.Length <= length)
                    {
                        tempArray[j++] = item;
                    }
                }
                sizeOutputArray = j;
                return tempArray;
            }

            string[] TruncateArray(string[] inputArray, int count) // чистка выходного массива
            {
                string[] tempArray = new string[count];
                int i = 0;
                while (i < count) tempArray[i] = inputArray[i++];
                return tempArray;
            }

            void PrintArray(string[] array) //  вывод массива по требованиям задачи
            {
                Console.Write("[");
                int count = 0;
                while (count < array.Length)
                {
                    if (count < array.Length - 1)   // танцы с бубном из за последней запятой
                    {
                        Console.Write($"\"{array[count]}\", ");
                    }
                    else
                    {
                        Console.Write($"\"{array[count]}\"");
                    }
                    count++;
                }
                Console.Write("]");
            }
        }
    }
}
