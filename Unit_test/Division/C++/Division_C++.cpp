/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
#include <iostream>
#include <exception>
using namespace std;
 
double divide(double, double);
 
int main()
{
    cout <<"Введите делимое\n";
    double a;
    std::cin >> a;
    cout <<"Введите делитель\n";
    double b;
    std::cin >> b;
    try
    {
        double s = divide(a, b);
        std::cout << s << std::endl;
    }
    catch (const std::exception& err)
    {
        std::cout << "Ошибка! На ноль делить нельзя!" << std::endl;
    }
    cout << "Размер типа данных int равен " << sizeof(int) << " bytes";
    cout << "\n";
    cout << "Размер типа данных float равен " << sizeof(float) << " bytes";
    cout << "\n";
    std::cout << "Конец программы" << std::endl;
    return 0;
}
double divide(double a, double b)
{
    if (b == 0)
        throw std::exception();
    return a / b;
}
