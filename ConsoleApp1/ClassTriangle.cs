using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //вводим стороны треугольника
            Console.WriteLine("Введи длину стороны А");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи длину стороны B");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи длину стороны C");
            double c = int.Parse(Console.ReadLine());

            Triangle triangle = new Triangle();
            triangle.InitializationSide(a,b,c);
            triangle.CheckTriangle(a,b,c);
            triangle.Perimeter(a,b,c);
            triangle.Square(a,b,c);
            triangle.Display();
            
        }
        class Triangle
        {
            private double sideA;
            private double sideB;
            private double sideC;

            //Метод инициализации сторон треугольника
            public void InitializationSide(double a, double b, double c)
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }
            //метод Проверка существует ли треугольник
            public void CheckTriangle(double a, double b, double c)
            {
                //if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine($"\nТреугольник с сторонами {a}, {b}, {c} существует");
                }
                else
                {
                    Console.WriteLine($"\nТреугольник с сторонами {a}, {b}, {c}  не существует");
                }
            }
            // метод для расчета периметра 
            public void Perimeter(double a, double b, double c)
            {
                double perimeter = a + b + c;
                Console.WriteLine($"\nПериметр треугольника = {perimeter}");
            }
            //метод для расчета площади
            public void Square(double a, double b, double c)
            {
                //треугольник равносторонний или неn
                if (a == b && a == c)
                //если треугольник равносторонний
                {
                    double square = (Math.Sqrt(3) / (4) * a * a);
                    Console.WriteLine($"\nТреугольник равносторонний. Площадь треугольника = {square}");
                }
                //если треугольник не равносторонний
                //считаем по формуле Герона
                else
                {
                    double semiPerimeter = a + b + c / 2;
                    double square = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
                    Console.WriteLine($"\nТреугольник неравносторонний. Площадь треугольника = {square}");
                }
            }
            //метод выводящий длины сторон на экран
            public void Display()
            {
                Console.WriteLine($"\nСтороны треугольника равны: сторона a = {sideA}, b = {sideB}, c = {sideC}");
            }
        }

    }
}