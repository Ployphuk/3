using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Circle 1");
        Console.Write("Enter Circle 1 center x:");
        double c1x = double.Parse(Console.ReadLine());
        Console.Write("Enter Circle 1 center y:");
        double c1y = double.Parse(Console.ReadLine());
        Console.Write("Enter Radius of Circle 1:");
        double c1r = double.Parse(Console.ReadLine());

        Console.WriteLine("Circle 2");
        Console.Write("Enter Circle 2 center x:");
        double c2x = double.Parse(Console.ReadLine());
        Console.Write("Enter Circle 2 center y:");
        double c2y = double.Parse(Console.ReadLine());
        Console.Write("Enter Radius of Circle 2:");
        double c2r = double.Parse(Console.ReadLine());

        Distance(c1x, c1y, c2x, c2y);
    }

    static void Distance(double c1x, double c1y, double c2x, double c2y){
        double result = Math.Sqrt(Math.Pow(c2x - c1x,2)+Math.Pow(c2y - c1y,2));

        Console.WriteLine("Result is {0}", result);
    }

    static void CheckIntersect(double c1x, double c1y, double c1r, double c2x, double c2y, double c2r, double result){
        if(result <= c1r + c2r){
            double a = (Math.Pow(c1r,c2r)-Math.Pow(c2r,2)+Math.Pow(result,2))/(2*result);
            double h = Math.Sqrt(Math.Pow(c1r,2) - Math.Pow(a, 2));

            double centerx = c1x + a * (c2x - c1x)/result;
            double centery = c1y + a* (c2y - c1y)/result;

            double x = h*(c2y - c1y)/result;
            double y = h*(c2x - c1x)/result;

            if(result == c1r + c2r){
                Console.WriteLine(centerx - x);
                Console.WriteLine(centery - y);
            }else{
                Console.WriteLine(centerx - x);
                Console.WriteLine(centery + y);
                Console.WriteLine(centerx + x);
                Console.WriteLine(centery - y);
            }
        }
    }
}