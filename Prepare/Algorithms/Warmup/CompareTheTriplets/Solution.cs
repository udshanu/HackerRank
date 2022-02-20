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
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var aliceArr = a.ToArray();
        var bobArr = b.ToArray();

        if (aliceArr.Length != bobArr.Length)
            return null;

        List<int> result = new List<int>();

        int alicePointCount = 0;
        int bobPointCount = 0;

        for (int i = 0; i < aliceArr.Length; i++)
        {
            if (aliceArr[i] > bobArr[i])
            {
                alicePointCount++;
            }
            else if (aliceArr[i] < bobArr[i])
            {
                bobPointCount++;
            }
        }

        result.Add(alicePointCount);
        result.Add(bobPointCount);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
