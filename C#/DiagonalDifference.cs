using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = new int[a_temp.Length];

                for (int a_j = 0; a_j < a_temp.Length; a_j++)
                {
                   a[a_i][a_j] = Convert.ToInt32(a_temp[a_j]);

                }
            }
        
            int d1 = 0;
            int d2 = n-1;
            int[] res = new int[2];
            
            for(int i = 0; i < n; i++){
                res[0] = res[0] + (a[i][d1]);
                res[1] = res[1] + (a[i][d2]);
                d1++;
                d2--;
            }            
            Console.WriteLine(Math.Abs(res[0] - res[1]));
         
    }
}
