using System;

public partial class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }
}

public partial class Calculator
{
    public int Mul(int a, int b)
    {
        return a * b;
    }

    public int Div(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }

        return a / b;
    }
}
