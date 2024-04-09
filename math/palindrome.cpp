//Intuition behind this solution.
//Reversal of Number: The main idea here is to reverse the number itself and then compare it with the original number.
// If they are the same, then the number is a palindrome.

//Isolating the Last Digit: In each iteration of the loop, it calculates x % 10 to get the last digit of x.
// This digit is then added to reversed after shifting the current digits of reversed one place to the left (or multiplying them by 10).
// This effectively appends the last digit of x to reversed.

//Removing the Last Digit: The last digit of x is then removed by doing integer division by 10 (x = x / 10).

//Comparison: After the loop, reversed holds the reverse of the original number. If reversed is equal to the original number, then the number is a palindrome, and the function returns true. Otherwise, it returns false.

#include <bits/stdc++.h>
using namespace std;

bool isPalindrome(int x){
    int reversed = 0;
    int number = x;
    while ( x > 0) {
        int last_digit = x % 10;
        reversed = reversed * 10 + last_digit;
        x = x / 10;
    }

    if (number == reversed) {
        return true;
    } else {
        return false;
    }

}


int main(){
    int numb;
    cin >> numb;
    bool result = isPalindrome(numb);
    cout << result << endl;
    return 0;
}  
