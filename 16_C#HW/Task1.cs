using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Task1
{

    public static T Max<T>(T num1, T num2, T num3) where T : IComparable<T>
    {

        T max = num1;


        if (num2.CompareTo(max) > 0)
        {

            max = num2;

        }

        if (num3.CompareTo(max) > 0)
        {

            max = num3;

        }

        return max;
    }
}
