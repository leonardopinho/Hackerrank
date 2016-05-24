using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int posCount = 0;
        int negCount = 0;
        int zeroCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroCount++;
            }
            else if (arr[i] > 0)
            {
                posCount++;
            }
            else if (arr[i] < 0)
            {
                negCount++;
            }                
        }

        Decimal result;

        result = Convert.ToDecimal(posCount) / n;
        Console.WriteLine(result.ToString("0.000000"));
        result = Convert.ToDecimal(negCount) / n;
        Console.WriteLine(result.ToString("0.000000"));
        result = Convert.ToDecimal(zeroCount) / n;
        Console.WriteLine(result.ToString("0.000000"));
    }
}
