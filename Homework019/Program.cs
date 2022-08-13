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

Console.WriteLine("Проверьте число на палиндромность");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);
if (num == Palindrome(num))
    Console.WriteLine("Yes, baby");
else
    Console.WriteLine("No, man");





