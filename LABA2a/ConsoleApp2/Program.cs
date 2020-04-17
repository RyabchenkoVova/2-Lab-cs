using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Масив треугольников
            Triangle[] triangles =
               {
                new Triangle(5,6,7),
                new Triangle(6,7,8),
                new Triangle(11,9,10),
                new Triangle(12,13,13),
                new Triangle(15,16,17),
                new Triangle(18,19,20)
            };
            //временная переменная
            double averageSquare = 0;
            //перебор масива
            for (int i = 0; i < triangles.Length - 1; i++)
            {
                averageSquare += triangles[i].Square();
            }
            Console.WriteLine(averageSquare / triangles.Length);
            Console.WriteLine(new string('=',100));
            //масив треугольников
            RightTriangle[] rightTriangles =
            {
                new RightTriangle(5,5),
                new RightTriangle(5,6),
                new RightTriangle(5,6),
                new RightTriangle(8,5),
                new RightTriangle(9,10),
                new RightTriangle(10,10)
            };


            RightTriangle tempVar = null;
            double tempVar1 = 0;
            //перебор масива для поиска с наибольшей гипотенузой
            for (int i = 0; i < rightTriangles.Length - 1; i++)
            {
                if (rightTriangles[i].NewMethod() > tempVar1)
                {
                    tempVar1 = rightTriangles[i].NewMethod();
                    tempVar = rightTriangles[i];
                }
            }
            Console.WriteLine("Прямоугольный треугольник с найбольшей гипотенузой");
            Console.WriteLine(tempVar.ToString());

            Console.ReadKey();
        }
    }
}
