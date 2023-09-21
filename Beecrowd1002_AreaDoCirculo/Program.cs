using System;
using System.Globalization;

namespace beecrowd {
    class Program1002 {

        static void Main(string[] args) {

            double raio, n, area;

            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}