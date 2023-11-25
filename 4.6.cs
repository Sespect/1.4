using System;

class Program
{
    public static void Main(string[] args)
    {
        double x = 0, y = 0;
        Console.WriteLine("Enter x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter y:");
        y = Convert.ToDouble(Console.ReadLine());

        double ax = 0, ay = 2;
        double bx = -2, by = -3;
        double dx = 2, dy = -3;
        double s = 0, s1 = 0, s2 = 0, s3 = 0;

        s = Math.Abs((ax * by + bx * dy + dx * ay - ay * bx - by * dx - dy * ax) / 2);
        s1 = Math.Abs((x * by + bx * dy + dx * y - y * bx - by * dx - dy * x) / 2);
        s2 = Math.Abs((ax * y + x * dy + dx * ay - ay * x - y * dx - dy * ax) / 2);
        s3 = Math.Abs((ax * by + bx * y + x * ay - ay * bx - by * x - y * ax) / 2);

        if (s == s1 + s2 + s3)
        {
            Console.WriteLine("The point belong to the area");
        }
        else
        {
            Console.WriteLine("The point does not belong to the area");
        }
    }
}