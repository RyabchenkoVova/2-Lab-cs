using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Triangle : TriangleMethods
    {
        private const string Message = "Треугольник не существует";
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;
        protected double perimeter;
        protected double square;
        protected double firstCorner;
        protected double secondCorner;
        protected double thirdCorner;
        protected bool A = true;

        public Triangle(double firstSide, double secondSide)
        {
            try
            {
                if (firstSide + secondSide > Gypotenusa(firstSide, secondSide) && //Проверка на существование треугольника
                    firstSide + Gypotenusa(firstSide, secondSide) > secondSide &&
                    secondSide + Gypotenusa(firstSide, secondSide) > firstSide)
                {
                    this.firstSide = firstSide;
                    this.secondSide = secondSide;
                    this.thirdSide = Gypotenusa(firstSide,secondSide);
                    this.perimeter = Perimeter();
                    this.square = Square();
                    Corners();
                }
                else throw new Exception(Message); //Ошибка на существование треугольника
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }//Ошибка на существование треугольника
            catch (Exception e) { Console.WriteLine(e.Message); }//Ошибка на введение данных
        }

        

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            try
            {
                if (firstSide + secondSide > thirdSide && //Проверка на существование треугольника
                    firstSide + thirdSide > secondSide &&
                    secondSide + thirdSide > firstSide)
                {
                    this.firstSide = firstSide;
                    this.secondSide = secondSide;
                    this.thirdSide = thirdSide;
                    this.perimeter = Perimeter();
                    this.square = Square();
                    Corners();
                }
                else throw new Exception(Message); //Ошибка на существование треугольника
            }
            catch (FormatException e) { Console.WriteLine(e.Message); }//Ошибка на существование треугольника
            catch (Exception e) { Console.WriteLine(e.Message);  }//Ошибка на введение данных
        }

        public override string ToString()//переопределенный метод ToString
        {
            if (A)
            {
                return string.Format($"Информация о треугольнике" +
                $"\nСторона а = {firstSide} Соотвествующий угол A = {firstCorner}" +
                $"\nСторона b = {secondSide} Соотвествующий угол B = {secondCorner}" +
                $"\nСторона c = {thirdSide} Соотвествующий угол C = {thirdCorner}" +
                $"\nПлощадь = {square}" +
                $"\nПериметр = {perimeter}");
            }
            else return Message;

        }

        public void Corners()//Формулы вычисления углов ,выведенные из теоремы косинусов
        {
            const double rad = 57.296;
            double c = Math.Acos((Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) - Math.Pow(thirdSide, 2)) / (2 * firstSide * secondSide));
            double b = Math.Acos((Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) - Math.Pow(secondSide, 2)) / (2 * firstSide * thirdSide));
            double a = Math.Acos((Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) - Math.Pow(firstSide, 2)) / (2 * secondSide * thirdSide));
            firstCorner = a*rad;
            secondCorner = b*rad;
            thirdCorner = c*rad;
        }

        public double Perimeter()//Периметр
        {
            return firstSide + secondSide + thirdSide;
        }


        public double Square()//Площадь по формуле Герона
        {
            double p = (firstSide + secondSide + thirdSide) / (2);
            double squareTemp = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return squareTemp;
        }
        
        private static double Gypotenusa(double firstSide, double secondSide)
        {
            return Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));
        }
    }
}
