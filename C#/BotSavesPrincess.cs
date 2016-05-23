using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution {
    
static void displayPathtoPrincess(int n, String [] grid){
    
    char bot = 'm';
    int bot_y = 0;
    int bot_x = 0;

    char prnc = 'p';
    int prnc_y = 0;
    int prnc_x = 0;

    for (int i = 0; i < grid.Length; i++)
    {
        if(grid[i].Contains(bot))
        {
            bot_y = i;
            char[] arr = grid[i].ToCharArray();

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == bot)
                {
                    bot_x = j;
                }
            }
        }
        else if (grid[i].Contains(prnc))
        {
            prnc_y = i;
            char[] arr = grid[i].ToCharArray();

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == prnc)
                {
                    prnc_x = j;
                }
            }
        }

    }

    int botMovX = prnc_x - bot_x;
    int botMovY = prnc_y - bot_y;

    if (botMovY > 0)
    {
        while (botMovY > 0)
        {
            Console.WriteLine("DOWN");
            botMovY--;
        }
    }
    else
    {
        while (botMovY < 0)
        {
            Console.WriteLine("UP");
            botMovY++;
        }
    }

    if (botMovX > 0)
    {
        while (botMovX > 0)
        {
            Console.WriteLine("RIGHT");
            botMovX--;
        }
    }
    else
    {
        while (botMovX < 0)
        {
            Console.WriteLine("LEFT");
            botMovX++;
        }
    }


  }
static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}
