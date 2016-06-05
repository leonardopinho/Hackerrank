#include "iostream"
#include "Config.h"
#include "map"
#include "sstream"
#include <vector>

using namespace std;

int main() {

    int n;
    cin >> n;

    map<string, string> phoneNumbers = {};
    map<string,string>::iterator it;
    vector<string> list;

    //set dictionary
    for (int i = 0; i < n; ++i) {

        string line;
        int c = 0;
        vector<string> t;

        while (cin >> line) {

            t.push_back(line);
            c++;

            if (c >= 2) break;

        }

        phoneNumbers[t[0]] = t[1];

    }

    //set list
    for (int i = 0; i < n; ++i) {
        string line;
        cin >> line;
        list.push_back(line);
    }

    for (int j = 0; j < n; ++j) {

        string res = "";

        it = phoneNumbers.find(list[j]);

        if (it != phoneNumbers.end()){
            res = phoneNumbers.find(list[j])->first + "=" + phoneNumbers.find(list[j])->second;
        }else{
            res = res == "" ? "Not found" : res;
        }

        cout << res << endl;

    }

    return 0;

}

