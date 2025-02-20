using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto car1 = new Avto();
            car1.Brand = "Лада";
            car1.Color = "розовый";
            car1.Skor = 70.2;
            Console.WriteLine($"{car1.ToString()}");
            Console.WriteLine();
            Avto car2 = new Avto("Ламборгини","красный",100);
            Console.WriteLine($"{car2.ToString()}");
            Console.WriteLine();

            Console.Write("Название марки: ");
            string brand = Console.ReadLine();
            Console.Write("Цвет: ");
            string color = Console.ReadLine();
            Console.Write("Скорость: ");
            double skor = double.Parse(Console.ReadLine());
            Avto car3 = new Avto(brand,color,skor);
            Console.WriteLine($"{car3.ToString()}");
            Console.ReadLine();
        }
    }
}
