using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Ввод кол-ва чисел
            List<int> ans = new List<int>(); // Создание "вектора" для хранения ответа
            string[] arr = Console.ReadLine().Split(); // Создание и ввод чисел через пробел
            for (int i = 0; i < N; i++) // Создание цикла для проверки каждого из чисел на простоту
            {
                int a = int.Parse(arr[i]); 
                int ok = 0;
                for (int j = (int)(Math.Sqrt(a)); j > 1 && ok == 0; j--)
                    if (a % j == 0)
                        ok = 1;
                if (ok == 0 && a != 1) // Вынужденно создаем условие для 1
                    ans.Add(a);
            }
            Console.WriteLine(ans.Count); // Вывод кол-ва простых чисел
            for (int i = 0; i < ans.Count; i++) 
                Console.Write(ans[i] + " "); // С помощью цикла вывод все простые числа через пробел
            Console.ReadKey(); // некий "system("pause")
        }
    }
}
