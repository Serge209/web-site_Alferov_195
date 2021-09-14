#include <iostream>
#include <exception>
 
double divide(int, int);
 
int main()
{
    int number1 = 18;
    int number2 = 0;
    try
    {
        double res = divide(number1, number2);
        std::cout << res << std::endl;
    }
    catch (const std::exception& err)
    {
        std::cout << "Error!!!" << std::endl;
    }
    std::cout << "The End..." << std::endl;
    return 0;
}
 
double divide(int number1, int number2)
{
    if (number2 == 0)
        throw std::exception();
    return number1 / number2;
}
