using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSimplePoint
{
    public class Point
    {
        private double x;
        private double y;

        //Конструктор
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойство Х
        public double X
        {
            get { return x; }
            // установка свойства Х с провекркой на допустимый диапазон
            set { if (x < 0 && x > 1000) x = value; }
        }

        // Свойство Y
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Свойство Dist - расстояние от точки до центра координат - ТОЛЬКО ДЛЯ ЧТЕНИЯ !!!
        public double Dist
        {
            get { return Math.Sqrt(x * x + y * y); }
        }

        // Метод - перемещение точки
        public void Move(double dx, double dy)
        {
            x = x + dx;
            y = y + dy;
        }

        // Метод - расстояние от текущей точки до произвольной точки "p"
        public double Distance(Point p)
        {
            double px = p.x - x;
            double py = p.y - y;
            return Math.Sqrt(px * px + p.y * p.y);
        }

        // Метод - вывод сведений о точке
        public void Passport()
        {
            Console.WriteLine("Point:  x={0}     y={1}", x, y);
        }
    }
}


