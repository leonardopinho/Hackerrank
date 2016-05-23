#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int factorial(int f){
    
    if(f == 1) return 1;
    
    int r = factorial(f-1) * f;
    
    return r;
    
}

int main() {
    int x;
    
    cin >> x;
    
    cout << factorial(x) << endl;
    
    return 0;
}
