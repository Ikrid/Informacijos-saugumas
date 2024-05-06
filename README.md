// ConsoleApplication3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <cmath>

double calculateRemainder(double base, double exponent, double divisor) {
    
    double result = pow(base, exponent);

    double remainder = fmod(result, divisor);

    return remainder;
}

int findD(int e, int f) {
    for (int d = 1; d <= f; ++d) {
        if ((d * e) % f == 1) {
            return d;
        }
    }
    return -1; 
}

int main() {

    int choice;
    std::cout << "Variantas:\n";
    std::cout << "1. Apskaičiuokite likutį, likusį dalijant iki galybės pakeltą skaičių iš kito skaičiaus\n";
    std::cout << "2. Raskite d reikšmę lygtyje (d * e) % f = 1\n";
    std::cin >> choice;

    if (choice == 1) {
    double base, exponent, divisor;
    std::cout << "Skaicius: ";
    std::cin >> base;
    std::cout << "Laipsnis: ";
    std::cin >> exponent;
    std::cout << "Dalyklis: ";
    std::cin >> divisor;

    double result = pow(base, exponent);

    double remainder = fmod(result, divisor);

    std::cout << "Liekana " << base << " laipsni " << exponent << " ant " << divisor << " lygu " << remainder << std::endl;

    }
    else if (choice == 2) {
           int e, f;
           std::cout << " e: ";
           std::cin >> e;
           std::cout << " f: ";
           std::cin >> f;

           int d = findD(e, f);

           if (d != -1) {
               std::cout << "Reiksme d v uravnenii (d * e) % f = 1: " << d << std::endl;
           }
           else {
               std::cout << "Nera tokio d" << std::endl;
           }
    }
       else {
           std::cout << "Neteisingas variantas\n";
    }
    

    return 0;
}
