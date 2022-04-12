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
    public static List<int> getMax(List<string> operations)
    {
        Stack<int> st = new Stack<int>();
        Stack<int> stMax = new Stack<int>();
        List<int> lsMax = new List<int>();

        foreach (var item in operations)
        {
            string[] array = item.Split();

            if (array[0].Equals("1"))
            {
                int t = Convert.ToInt32(array[1]);
                st.Push(t);

                if (stMax.Count == 0 || t >= stMax.Peek())
                {
                    stMax.Push(t);
                }
                else
                {
                    stMax.Push(stMax.Peek());
                }

            }
            else if (array[0].Equals("2"))
            {
                st.Pop();
                stMax.Pop();
            }
            else if (array[0].Equals("3"))
            {
                int m = stMax.Peek();
                lsMax.Add(m);
            }
        }

        return lsMax;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> ops = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string opsItem = Console.ReadLine();
            ops.Add(opsItem);
        }

        List<int> res = Result.getMax(ops);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
