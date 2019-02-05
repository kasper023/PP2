using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = s;
            bool check = true;
            for( int i = 0; i < s.Length && check == true; i++)
                if (t[s.Length - i - 1] != s[i])
                    check = false;
            if (check == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}