using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matematik İşlemleri
            MathOperations math = new MathOperations();
            Console.WriteLine("Matematik İşlemleri:");
            Console.WriteLine("İki sayı toplamı: " + math.Sum(5, 10));
            Console.WriteLine("Üç sayı toplamı: " + math.Sum(5, 10, 15));
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Dizi toplamı: " + math.Sum(numbers));
            Console.WriteLine();

            // Şekillerin Alanını Hesaplama
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();
            Console.WriteLine("Şekillerin Alanını Hesaplama:");
            Console.WriteLine("Karenin alanı: " + calculator.CalculateArea(4));
            Console.WriteLine("Dikdörtgenin alanı: " + calculator.CalculateArea(4, 6));
            Console.WriteLine("Dairenin alanı: " + calculator.CalculateArea(3.5));
            Console.WriteLine();

            // Zaman Farkı Hesaplama
            DateDifferenceCalculator dateCalculator = new DateDifferenceCalculator();
            DateTime date1 = new DateTime(2022, 1, 1);
            DateTime date2 = DateTime.Now;

            Console.WriteLine("Zaman Farkı Hesaplama:");
            Console.WriteLine("Gün farkı: " + dateCalculator.CalculateDifference(date1, date2));
            Console.WriteLine("Saat farkı: " + dateCalculator.CalculateDifferenceInHours(date1, date2));

            var detailedDiff = dateCalculator.CalculateDetailedDifference(date1, date2);
            Console.WriteLine($"Yıl: {detailedDiff.years}, Ay: {detailedDiff.months}, Gün: {detailedDiff.days}");
            Console.Read();
        }
    }
}
