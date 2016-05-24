using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Solution {
    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(arr_temp[0]);
        int b = Convert.ToInt32(arr_temp[1]);
        int n = Convert.ToInt32(arr_temp[2]);

        Console.WriteLine(fibonacci(a, b, n-2));
        Console.ReadKey();
    }
    
   private static BigInteger fibonacci(BigInteger a, BigInteger b, int n)
    {
        if (n == 0)
        {
            return b;
        }
        else
        {
            BigInteger r = b * b;
            return fibonacci(b, r + a, n - 1);
        }
    }
}