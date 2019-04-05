using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikl
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i*i}");
            }
            Console.ReadLine();

            int B = 0;
            for (; B < 9;)
            {
                Console.WriteLine($"Квадрат числа {++B} равен {B* B}");
            }
            Console.ReadLine();

            int a = 6;
            do
            {
                Console.WriteLine(a);
                a--;
            }
            while (a > 0);
            Console.ReadLine();

            int w = 6;
            while(w>0)
            {
                Console.WriteLine(w);
                w--;
            }
            Console.ReadLine();

            for(int b=0; b<9; b++)
            {
                if (b == 5)
                    break;
                Console.WriteLine(b);
            }
            Console.ReadLine();



        }

    }
}
