using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        var array = arr.ToArray();
        Array.Sort(array);

        long sumOfMin = 0;
        long sumOfMax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                sumOfMin = sumOfMin + array[i];
            }

            if (1 <= i)
            {
                sumOfMax = sumOfMax + array[i];
            }
        }

        Console.Write($"{sumOfMin} {sumOfMax}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
