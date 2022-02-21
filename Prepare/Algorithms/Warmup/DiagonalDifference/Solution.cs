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
    public static int diagonalDifference(List<List<int>> arr)
    {
        int[][] arrays = arr.Select(a => a.ToArray()).ToArray();

        int leftToRightDiagonalSum = 0;
        int rightToLeftDiagonalSum = 0;
        int leftIndex = arrays.Length - 1;

        for (int i = 0; i < arrays.Length; i++)
        {
            leftToRightDiagonalSum = leftToRightDiagonalSum + arrays[i][i];

            rightToLeftDiagonalSum = rightToLeftDiagonalSum + arrays[i][leftIndex];
            leftIndex--;
        }

        int result = Math.Abs(leftToRightDiagonalSum - rightToLeftDiagonalSum);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
