//Problem 4. Triangle surface

//    Write methods that calculate the surface of a triangle by given:
//        Side and an altitude to it;
//        Three sides;
//        Two sides and an angle between them;
//    Use System.Math.


using System;

class calculateSurface
{
    static void Main()
    {
        Console.WriteLine(SurfaceAltitude(a: 15,h: 8));
        Console.WriteLine(SurfaceSides(a: 8, b: 13 , c: 10));
        Console.WriteLine(SurfaceAngle(a: 18, b: 20, alpha: 15));
    }
    static double SurfaceAltitude(double a, double h)
    {
        double surface = (a * h) / 2;
        return surface;
    }
    static double SurfaceSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static double SurfaceAngle(double a, double b, double alpha)
    {
        double surface = (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
        return surface;
    }
}

