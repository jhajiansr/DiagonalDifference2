using System;
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
using System.Numerics;


   

public  class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *i
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

   
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[,] arr = new int[100,100];

            int arrTemp1 = 0;

            for (int i = 0; i < n; i++)
            {

                arrTemp1 = Convert.ToInt32(Console.ReadLine().TrimEnd()); //.Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp1));
                arr.SetValue(arrTemp1, i);
            }

            int result = Result.DiagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    public static int DiagonalDifference(int[,] arr)
    {
        int s1 = 0;
        int s2 = 0;
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            s1 += arr[i,i];
            s2 += arr[i,n-i-1];
        }
        return +(s1 - s2);
    }

}


