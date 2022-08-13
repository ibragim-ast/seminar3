int Palindrome(int num1)
{
    int num2 = 0;
    int digit = 0;
    while (num1 > 0)
    {          
        digit = num1 % 10; 
        num1 = num1 / 10;
        num2 = num2 * 10 + digit;           
    }
    return num2;
}
int result = Palindrome(45654);
Console.WriteLine(result);




