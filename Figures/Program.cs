using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public interface IFigureMath
    {
        double GetSquare();
    }

    public class Treangle : IFigureMath
    {
        public double X_1
        { set; get; }

        public double X_2
        { set; get; }

        public double X_3
        { set; get; }

        public double Y_1
        { set; get; }

        public double Y_2
        { set; get; }

        public double Y_3
        { set;get; }

        public Treangle()
        { }
        public Treangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            X_1 = x1;
            X_2 = x2;
            X_3 = x3;
            Y_1 = y1;
            Y_2 = y2;
            Y_3 = y3;
        }

        public double GetSquare()
        {
            double res = Math.Abs(0.5*((X_1 - X_3) * (Y_2 - Y_3) - (X_2 - X_3) * (Y_1 - Y_3)));
            return res;
        }

        public bool IsRect()
        {
            double p1, p2, p3, d1, d2, d3;
            
            p1 = Math.Sqrt((X_2 - X_1) * (X_2 - X_1) + (Y_2 - Y_1) * (Y_2 - Y_1));
            p2 = Math.Sqrt((X_3 - X_1) * (X_3 - X_1) + (Y_3 - Y_1) * (Y_3 - Y_1));
            p3 = Math.Sqrt((X_3 - X_2) * (X_3 - X_2) + (Y_3 - Y_2) * (Y_3 - Y_2));
            
            d1 = p1 * p1;
            d2 = p2 * p2;
            d3 = p3 * p3;
            
            if ((d1 - d2 + d3 < 0.0001) || (d2 - d1 + d3 < 0.0001) || (d3 - d1 + d2 < 0.0001))
                return true;
            else
                return false;
            
        }

    }

    public class Circle: IFigureMath
    {
        public double R
        { set; get; }

        public Circle()
        { }

        public Circle(double r)
        {
            R = r;
        }

        public double GetSquare()
        {
            double res = Math.PI * R * R;
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Treangle tr1 = new Treangle(x1:1, x2:3, x3:3, y1:1, y2:3, y3:-1);
            Console.WriteLine("S - {0}", tr1.GetSquare());
            Console.WriteLine("Is Rectangle - {0}", tr1.IsRect().ToString());
            Console.ReadLine();
        }
    }
}
