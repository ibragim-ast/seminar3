//Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
void TableCube(int num)
{
    int i = 1;
    while (num >= i)
    {
        Console.Write($"{i * i * i} ");
        i++;
    }
        
}

TableCube(3);


