

int Cube(int num)
{
    while (index < num)
    num1 = num * num * num;
    index++;
    return num1;
}

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());
int b = Cube(a);
Console.WriteLine(b);


