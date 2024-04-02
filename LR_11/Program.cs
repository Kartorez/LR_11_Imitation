using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    public interface IScalable
    {
        void Scale(double s);

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            Circle circle = new Circle(10);
            Console.WriteLine($"Радіус кола {circle.Radius}");
            circle.Scale(2);
            Console.WriteLine($"Радіус кола після масштабування {circle.Radius}");

            Triangle triangle = new Triangle(20,40);
            Console.WriteLine($"висота прямокутника  {triangle.Height} Ширина прямокутника {triangle.Width}");
            triangle.Scale(3);
            Console.WriteLine($"Після масштабування висота прямокутника  {triangle.Height} Ширина прямокутника {triangle.Width}");
            Console.ReadLine();

        }
    }

}
