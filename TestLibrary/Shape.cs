namespace TestLibrary
{
    public class Shape
    {
        //public static double shapeArea(double x)
        //{
        //    double area = function(x);
        //    return area;
        //}
        public static double circleArea(double radius)
        {
            if (radius < 0)
            {
                return -1;
            }
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public static double triangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                return -1;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return -1;
            }
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        public static bool isTriangleRight(double a, double b, double c)
        {
            double x = 0, y = 0, z = 0;
            if (a < c && b < c)
            {
                x = a;
                y = b;
                z = c;
            }
            else if (b < a && c < a)
            {
                x = b;
                y = c;
                z = a;
            }
            else if (a < b && c < b)
            {
                x = a;
                y = c;
                z = b;
            }
            else
            {
                x = a;
                y = b;
                z = c;
            }
            return Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2);
        }
    }
}