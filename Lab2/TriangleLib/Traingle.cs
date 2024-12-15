using System;

public class Triangle
{
    public static string GetTriangleType(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0) return "Invalid";

        if (a + b <= c || a + c <= b || b + c <= a) return "Not a Triangle";

        bool isRight = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                       Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                       Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);

        if (a == b && b == c) return "Equilateral";
        if (a == b || b == c || a == c) return "Isosceles";
        if (isRight) return "Right";

        return "Scalene";
    }
}
