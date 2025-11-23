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
            triangle.CheckTriangle();
            triangle.Perimeter();
            triangle.Square();
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
            public void CheckTriangle()
            {
                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    Console.WriteLine($"\nТреугольник с сторонами {sideA}, {sideB}, {sideC} существует");
                }
                else
                {
                    Console.WriteLine($"\nТреугольник с сторонами {sideA}, {sideB}, {sideC}  не существует");
                }
            }
            // метод для расчета периметра 
            public void Perimeter()
            {
                double perimeter = sideA + sideB + sideC;
                Console.WriteLine($"\nПериметр треугольника = {perimeter}");
            }
            //метод для расчета площади
            public void Square()
            {
                //треугольник равносторонний или неn
                if (sideA == sideB && sideA == sideC)
                //если треугольник равносторонний
                {
                    double square = (Math.Sqrt(3) / (4) * sideA * sideA);
                    Console.WriteLine($"\nТреугольник равносторонний. Площадь треугольника = {square}");
                }
                //если треугольник не равносторонний
                //считаем по формуле Герона
                else
                {
                    double semiPerimeter = sideA + sideB + sideC / 2;
                    double square = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
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