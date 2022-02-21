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
    public static void plusMinus(List<int> arr)
    {
        var givenArray = arr.ToArray();

        if (givenArray.Length == 0)
        {
            return;
        }

        decimal positiveValuesCount = 0;
        decimal negativeValuesCount = 0;
        decimal zeroValuesCount = 0;

        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i] > 0)
            {
                positiveValuesCount++;
            }
            else if (givenArray[i] < 0)
            {
                negativeValuesCount++;
            }
            else
            {
                zeroValuesCount++;
            }
        }

        decimal positiveValuesProportion = positiveValuesCount / givenArray.Length;
        decimal negativeValuesProportion = negativeValuesCount / givenArray.Length;
        decimal zeroValuesProportion = zeroValuesCount / givenArray.Length;


        Console.WriteLine(positiveValuesProportion.ToString("N6")); //Positive
        Console.WriteLine(negativeValuesProportion.ToString("N6")); //Negative
        Console.WriteLine(zeroValuesProportion.ToString("N6")); //Zero
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
