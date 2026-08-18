#include "bits/stdc++.h"
#include <iostream>
#include <windows.h>
#include <locale>
#include <list>
#include <limits>

using namespace std;

int main()
{

    SetConsoleOutputCP(65001);       // permite que o terminal mostre caracteres utf-8 corretamente
    setlocale(LC_ALL, "pt_BR.utf8"); // permite usar acentuação e interpretar caracteres utf-8

    list<int> grades;
    list<string> students = {"Marcos", "Paulo", "Astolfo", "Pedro", "Arantes"};

    int grade;
    cin >> grade;

    grades.push_back(grade);

    auto it = grades.begin();
    cout << *it << endl;
}