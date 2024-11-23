using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    class ShapeAreaCalculator
    {
        // İlk sürüm: Karenin alanını hesaplar
        public int CalculateArea(int side)
        {
            return side * side;
        }

        // İkinci sürüm: Dikdörtgenin alanını hesaplar
        public int CalculateArea(int length, int width)
        {
            return length * width;
        }

        // Üçüncü sürüm: Dairenin alanını hesaplar
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
