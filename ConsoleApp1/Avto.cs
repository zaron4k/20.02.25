using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avto
    {
        private string brand;
        private string color;
        private double skor;

        public string Brand
        { get { return brand;} 
          set 
            {
               brand = value; 
            } 
        }
        public string Color
        { get { return color; } 
          set 
            { 
               color = value; 
            } 
        }
        public double Skor 
        { 
            get { return skor;} 
            set 
            { 
                if (value < 20) 
                    skor = 20; 
                else if (value > 120) 
                    skor = 120;
                else skor = value;
            } 
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Avto ()
        { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="brond"></param>
        public Avto (string brand, string color, double skor)
        {
            this.Brand = brand;
            this.Color = color;
            this.Skor = skor;
        }
        public override string ToString()
        {
            return $"Марка: {Brand}\nЦвет: {Color}\nСкорость: {Skor} км/ч";
        }

    }
}
