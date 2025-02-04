using System;

struct Complex
{
    public float Real;
    public float Img;

    public Complex(float real, float img)
    {
        Real = real;
        Img = img;
    }

    public static Complex Add(Complex num1, Complex num2)
    {
        return new Complex(num1.Real + num2.Real, num1.Img + num2.Img);
    }

    public static Complex Subtract(Complex num1, Complex num2)
    {
        return new Complex(num1.Real - num2.Real, num1.Img - num2.Img);
    }

    public override string ToString()
    {
        return $"{Real} {(Img >= 0 ? "+" : "-")} {Math.Abs(Img)}i";
    }
}

class Program
{
    static void Main()
    {
        Complex num1 = new Complex(3.5f, 2.5f);
        Complex num2 = new Complex(1.5f, 1.0f);

        Complex sum = Complex.Add(num1, num2);
        Complex difference = Complex.Subtract(num1, num2);

        Console.WriteLine($"Number 1: {num1}");
        Console.WriteLine($"Number 2: {num2}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
    }
}
