using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class Task3
{

    public static T Sum<T>(T[] array) where T : struct
    {


        dynamic sum = default(T);



        foreach (T item in array)
        {
            sum += (dynamic)item;
        }


        return sum;
    }
}
