using System;

class Program
{
    static void Main(string[] args)
    {
		

        Console.Write("Enter P1 x point: ");
		double P1x = double.Parse(Console.ReadLine());
		Console.Write("Enter P1 y point: ");
		double P1y = double.Parse(Console.ReadLine());
		Console.Write("Enter P2 x Point: ");
		double P2x = double.Parse(Console.ReadLine());
		Console.Write("Enter P2 y point: ");
		double P2y = double.Parse(Console.ReadLine());
		Console.Write("Enter P3 x point: ");
		double P3x = double.Parse(Console.ReadLine());
		Console.Write("Enter P3 y point: ");
		double P3y = double.Parse(Console.ReadLine());

		CenterPoint(P1x, P1y, P2x,  P2y, P3x, P3y);
	
	
    }

	public static void CenterPoint(double P1x, double P1y, double P2x, double P2y, double P3x, double P3y){
		
		double h,k;
		h = ((P2y - P1y)*(P3y*P3y-P1y*P1y+P3x*P3x-P1x*P1x)+(P3y-P1y)*(P1y*P1y-P2y*P2y+P1x*P1x-P2x*P2x))/(2*(P3x-P1x)*(P2y-P1y)-2*(P2x-P1x)*(P3y-P1y));
		k = ((P2x-P1x)*(P3x*P3x-P1x*P1x+P3y*P3y-P1y*P1y)+(P3x-P1x)*(P1x*P1x-P2x*P2x+P1y*P1y-P2y*P2y))/(2*(P3y-P1y)*(P2x-P1x)-2*(P2y-P1y)*(P3x-P1x));

		Console.WriteLine("Center point is {0}, {1}",h,k);
		
	}

	public static  void Radius(double P1x, double P1y, double P2x, double P2y, double P3x, double P3y, double h, double k){
		double r = Math.Sqrt((P1x - h)*(P1x - h)+(P1y - k)* (P1y - k));
		Console.WriteLine("Radisu is {0}",r);
	}

	
}