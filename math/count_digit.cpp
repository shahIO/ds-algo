//Intuition behind the solution.-

//1. Handle Negative Numbers:
// Since the sign of the number doesn’t affect the count of digits, you can convert the number to its absolute value.
// This is what x = abs(x); does.
// It ensures that the number you’re working with is always positive.

//2. Counting the Digits: The main idea here is to repeatedly divide the number by 10 until the number becomes 0. Each time you do this, you effectively “remove” the last digit of the number.
// For example, if you have the number 123, and you divide it by 10, you get 12.3. When you convert this back to an integer, you get 12, effectively removing the last digit (3).
// So, the loop while (x > 0){ x = x/10; count++; } does exactly this. It divides the number by 10, and increments a count.
// This count, therefore, represents the number of times you can divide by 10 before reaching 0, which is exactly the number of digits in the original number.



#include<bits/stdc++.h>
using namespace std;

int c_digit(int x){
    int count = 0;
    if (x < 0) {
        x = abs(x);
    }

    while (x > 0){
        x = x/10;
        count++;
    }
    return count;
}

int c_digit_2(int x){
    if ( x < 0) {
        x = abs(x);
    }
    std::string str = std::to_string(x);
    return str.length();
}


int main()
{
    int input;
    cin >> input;

    cout << c_digit(input) << endl;
    cout << c_digit_2(input) << endl;
}