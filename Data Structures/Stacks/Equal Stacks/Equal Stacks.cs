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
    public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
    {
        Stack<int> sh1 = new Stack<int>();
        Stack<int> sh2 = new Stack<int>();
        Stack<int> sh3 = new Stack<int>();

        int th1 = 0;
        int th2 = 0;
        int th3 = 0;

        var h1Array = h1.ToArray();
        var h2Array = h2.ToArray();
        var h3Array = h3.ToArray();

        for (int i = h1Array.Length - 1; i >= 0; i--)
        {
            th1 += h1[i];
            sh1.Push(th1);
        }

        for (int i = h2Array.Length - 1; i >= 0; i--)
        {
            th2 += h2[i];
            sh2.Push(th2);
        }

        for (int i = h3Array.Length - 1; i >= 0; i--)
        {
            th3 += h3[i];
            sh3.Push(th3);
        }

        while (true)
        {
            if (sh1.Count == 0 || sh2.Count == 0 || sh3.Count == 0)
                return 0;


            int sh1UpperHeight = sh1.Peek();
            int sh2UpperHeight = sh2.Peek();
            int sh3UpperHeight = sh3.Peek();

            if (sh1UpperHeight == sh2UpperHeight && sh2UpperHeight == sh3UpperHeight)
                return sh1UpperHeight;

            if (sh1UpperHeight >= sh2UpperHeight && sh1UpperHeight >= sh3UpperHeight)
                sh1.Pop();
            else if (sh2UpperHeight >= sh1UpperHeight && sh2UpperHeight >= sh3UpperHeight)
                sh2.Pop();
            else if (sh3UpperHeight >= sh1UpperHeight && sh3UpperHeight >= sh2UpperHeight)
                sh3.Pop();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n1 = Convert.ToInt32(firstMultipleInput[0]);

        int n2 = Convert.ToInt32(firstMultipleInput[1]);

        int n3 = Convert.ToInt32(firstMultipleInput[2]);

        List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

        List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

        List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

        int result = Result.equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
