#include <iostream>
#include <string>
#include <vector>
#include <sstream>

using namespace std;

struct Record
{
    std::string name, last_name, middle_name;
};

int main()
{

    setlocale(LC_ALL, "RU-ru");
    const int N = 1;
    Record r[N];
    for (int i = 0; i < N; i++)
    {
        std::cout << "Введите ФИО через пробел:";
        std::string data;
        std::cin.ignore();
        std::getline(std::cin, data);
        std::istringstream ist(data);
        ist >> r[i].last_name >> r[i].name >> r[i].middle_name;
    }
    for (int i = 0; i < N; i++)
    {
        std::cout << "ФИО:\t" << r[i].last_name << " " << r[i].name << " " << r[i].middle_name;
    }

    system("pause");
    return 0;
}
