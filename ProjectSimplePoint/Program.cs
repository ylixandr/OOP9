using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSimplePoint
{
    class Program
    {
        // Демонстрация некоторых возможностей класса Point
        static void Main(string[] args)
        {

             void TotalArea(Circle[] circles1)
            {
                var res = circles1.Sum(a => a.Area);
                Console.WriteLine("\nОбщая площадь: "+res);
            }
            // Создание точки. вывод сведений о точке
            Point p1 = new Point(10, 100);
            p1.Passport();

            // Перемещение точки
            p1.Move(20, 70);
            p1.Passport();

            // Задание нового значения свойства Х. Обратите внимание: изменился ли результат !!! 
            p1.X = 2000;
            p1.Passport();

            // Еще одна точка
            Point p2 = new Point(2, 2);
            // Вычисляем и печатаем расстояние от точки "р2" до точки "р1". Точка "р2" - текущая точка
            double distanceFromP2ToP1 = p2.Distance(p1);
            Console.WriteLine("расстояние от р2 до р1 = {0}", distanceFromP2ToP1);


            Circle c1 = new Circle(0, 0, 3);
            Console.WriteLine($"\nПроверка Площадь круга:{c1.Area}");
            Circle c2 = new Circle(0,1,3);  
            Circle c3 = new Circle(0,2,4);

            Circle[] circles = new Circle[] { c1, c2, c3 };
            TotalArea(circles);
            
        }
    }
}

 