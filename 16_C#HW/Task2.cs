using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Task2
{
    public static T Min<T>(T num1, T num2, T num3) where T : IComparable<T>
    {


        T min = num1;



        if (num2.CompareTo(min) < 0)
        {

            min = num2;


        }


        if (num3.CompareTo(min) < 0)
        {

            min = num3;

        }

        return min;
    }
}