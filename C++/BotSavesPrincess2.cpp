#include <iostream>
#include <vector>
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <algorithm>

using namespace std;

void nextMove(int n, int r, int c, vector <string> grid){
    
    char bot = 'm';
    int bot_y = 0;
    int bot_x = 0;
    
    char prnc = 'p';
    int prnc_y = 0;
    int prnc_x = 0;
    
    for(int i = 0; i < grid.size(); i++){
        
        if(grid[i].find(bot) != string::npos){
            
            bot_y = i;
            
            int len = int(grid[i].size());
            
            char arr[len];
            
            strcpy(arr, grid[i].c_str());
            
            for(int j = 0; j < len; j++){
                
                if(arr[j] == bot){
                    bot_x = j;
                }
                
            }
            
        }
        
        if(grid[i].find(prnc) != string::npos){
            
            prnc_y = i;
            
            int len = int(grid[i].size() + 1);
            
            char arr[len];
            
            strcpy(arr, grid[i].c_str());
            
            for(int j = 0; j < len; j++){
                
                if(arr[j] == prnc){
                    prnc_x = j;
                }
                
            }
            
        }
        
    }
    
    int botMovX = prnc_x - bot_x;
    int botMovY = prnc_y - bot_y;
    
    if(prnc_y != bot_y){
        if (botMovY > 0)
        {
            cout << "DOWN" << endl;
            botMovY--;
        }
        else if (botMovY <= 0)
        {
            cout << "UP" << endl;
            botMovY++;
        }
    }else{
        if (botMovX > 0)
        {
            cout << "RIGHT" << endl;
            botMovX--;
        }
        else if (botMovX <= 0)
        {
            cout << "LEFT" << endl;
            botMovX++;
        }
    }
    
}

int main(void) {
    int n, r, c;
    vector <string> grid;
    
    cin >> n;
    cin >> r;
    cin >> c;
    
    for(int i=0; i<n; i++) {
        string s; cin >> s;
        grid.push_back(s);
    }
    
    nextMove(n, r, c, grid);
    return 0;
}