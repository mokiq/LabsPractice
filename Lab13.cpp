#include <iostream>
#include <unistd.h>

using namespace std;


class Rocket
{
private:
    string name = {};
public:
    Rocket()
    {
        name = "";
    }

    Rocket(string Name)
    {
        name = Name;
    }

    string GetName() { return name; }
};

class AirPlane
{
private:
    int speed = {};
    float wingLength = {};
public:
    AirPlane()
    {
        speed = 0;
        wingLength = 0.0f;
    }

    AirPlane(int Speed, int WingLength)
    {
        speed = Speed;
        wingLength = WingLength;
    }

    int GetSpeed() { return speed; }
    float GetWingLength() { return wingLength; }
};

class JetPlane : public Rocket, public AirPlane
{
private:
    int yearOfProd = {};
public:
    JetPlane(string Name, int Speed, float WingLength, int YearOfProd) : AirPlane(Speed, WingLength), Rocket(Name)
    {
        yearOfProd = YearOfProd;
    }

    JetPlane(string Name, int Speed, float WingLength) : AirPlane(Speed, WingLength), Rocket(Name)
    {
        yearOfProd = 0;
    }

    JetPlane() { yearOfProd = 0; }

    int GetYear() { return yearOfProd; }


    void GetInfo()
    {
        cout << GetName() << "/" << GetSpeed() << "/" << GetWingLength() << "/" << GetYear() << endl;
    }
};

class B747 : public JetPlane
{
private:
    std::string name{};

public:
    B747(string Name) : JetPlane()
    {
        name = Name;

    }

    B747() : JetPlane()
    {

    }

    B747(string Name, int Speed, float WingLength, int YearOfProd) : JetPlane(Name, Speed, WingLength, YearOfProd)
    {
        name = Name;
    }

    B747(string Name, int Speed, float WingLength) : JetPlane(Name, Speed, WingLength)
    {
        name = Name;
    }
};

void MenuInfo()
{
    cout << "1 - Create B747" << endl;
    cout << "0 - exit" << endl;
}


int main()
{

    int menu_opt(3);

    while (menu_opt != 0)
    {
        MenuInfo();

        cin >> menu_opt;

        switch (menu_opt)
        {
        case 0: // exit
            break;
        case 1: // create object
            // Vars
            string name;
            int speed;
            float wingLength;
            int yearOfProd;

            // Conf
            cout << "Enter Name - " << endl;
            cin >> name;

            cout << "Enter speed of plane - " << endl;
            cin >> speed;

            cout << "Enter Wing length - " << endl;
            cin >> wingLength;

            cout << "Enter Year of prod - " << endl;
            cin >> yearOfProd;

            B747 obj(name, speed, wingLength, yearOfProd);

            cout << name << " was created!" << endl;
            obj.GetInfo();
            break;

        }
    }

    return 0;
}
