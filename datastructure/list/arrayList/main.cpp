#include "./ArrayList.h"
#include <iostream>
#include <string>

using namespace std;
int main()
{
    ArrayList<string> list;

    for(int i=0; i<5; i++){
        list.insert("test" + to_string(i));
    }

    list.pop_back();

    for(int i=0; i<list.size(); i++)
    {
        cout << list.get(i) << '\n';
    }
    
}