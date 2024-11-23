using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    class MathOperations
    {
        // İlk sürüm: İki tam sayıyı toplar
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // İkinci sürüm: Üç tam sayıyı toplar
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Üçüncü sürüm: Bir dizi tam sayıyı toplar
        public int Sum(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }
    }
}
