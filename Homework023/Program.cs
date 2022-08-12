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


