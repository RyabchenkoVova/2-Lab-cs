using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RightTriangle : Triangle
    {
        double gypotenusa;

        public RightTriangle(double firstSide, double secondSide) : base(firstSide,secondSide)
        {
            gypotenusa = NewMethod();
            try
            {
                if (firstCorner != 90 && secondCorner != 90 && thirdCorner == 90)
                {
                    throw new Exception("Треугольник не прямоугольный");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public  double NewMethod()
        {
            return Math.Sqrt(Math.Pow(firstSide,2)+ Math.Pow(secondSide, 2));
        }
    }
}
