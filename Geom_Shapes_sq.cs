using System;

namespace Geometric_shapes_square
{
    public class Geom_Shapes_sq
    {
        /// <summary>
        /// Triangle`s square by three sides
        /// </summary>
        /// <param name="a">first side of triangle</param>
        /// <param name="b">second side of triangle</param>
        /// <param name="c">third side of triangle</param>
        /// <returns>square of triangle</returns>
        public double Get_Square_of_triangle(int a = 0, int b = 0, int c = 0)
        {
            double p = 0;
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentException("Похоже, что одна из сторон равна 0");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
            {
                //проверку на то, что треугольник прямоугольный в данном контексте решения назвал бы избыточной, так как вычисление площади через формулу Герона для прямоугольного треугольника аналогично
                if (a < c || a < b)
                {
                    if (c < b)
                    { return a * c / 2; }
                    else
                    { return a * b / 2; }
                }
                else
                {
                    return b * c / 2;
                }
            }
            else
            { 
                //применяем формулу Герона, если все хорошо
                p = (a + b + c)/2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        /// <summary>
        /// Circle`s square by radius
        /// </summary>
        /// <param name="d">radius of circle</param>
        /// <returns>square of circle</returns>
        public double Get_Square_of_circle(double r = 0)
        {
            if (r == 0)
            {
                throw new ArgumentException("Похоже, что вы забыли передать радиус");
            }
            else
            {
                return Math.PI * r * r;
            }
        }

        /// <summary>
        /// calculating the perimeter of a regular polygon
        /// </summary>
        /// <param name="sides">array of sides a polygon</param>
        /// <returns>perimeter</returns>
        private double perimeter(double[] sides)
        {
            if (sides.Length == 0)
            {
                throw new ArgumentNullException("Похоже, что вы забыли передать стороны вышей фигуры");
            }
            else
            {
                double p = 0;
                for (int i = 0; i < sides.Length; i++)
                {
                    p += sides[i];
                }
                return p;
            }
        }

        public double Get_Square_of_polygon(double[] sides)
        {
            if (sides.Length == 0)
            {
                throw new ArgumentNullException("Похоже, что вы забыли передать стороны вышей фигуры");
            }
            else
            {
                double p = 0;
                for (int i = 0; i < sides.Length; i++)
                {
                    p += sides[i];
                }
                return p;
            }
        }
    }
}
