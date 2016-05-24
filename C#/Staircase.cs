using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int c = 0;
        
        for (int i = n - 1; i >= 0; i--)
        {
            string temp = string.Empty;

            for (int j = 0; j < n; j++)
            {
                temp += j >= i ? "#" : " ";
            }

            c++;

            Console.WriteLine(temp);
        }
    }
}
