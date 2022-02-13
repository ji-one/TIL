// https://www.acmicpc.net/problem/1914
#include <iostream>
#include <vector>
#include <cmath>
using namespace std;
int n, k;
vector<pair<int, int> > v;
void hanoi(int num, int from, int by, int to)
{
    if (num == 1)
    {
        v.push_back({from, to});
    }
    else
    {
        hanoi(num - 1, from, to, by);
        v.push_back({from, to});
        hanoi(num - 1, by, from, to);
    }
}
int main()
{
    cin >> n;
    string k = to_string(pow(2, n));
    k = k.substr(0, k.find('.'));
    k[k.length()-1] -= 1;
    cout << k << '\n';
    if (n <= 20)
    {
        hanoi(n, 1, 2, 3);
        for (int i = 0; i < v.size(); i++)
        {
            cout << v[i].first << ' ' << v[i].second << '\n';
        }
    }
}