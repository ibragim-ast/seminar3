

//Метод с возвратом значения
// int FindQuarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     return 1;
// else if (x < 0 && y > 0)
//     return 2;
// else if (x < 0 && y < 0)
//     return 3;
// else if (x > 0 && y < 0)
//     return 4;

// return 0;
// }

// Console.WriteLine(FindQuarter(4, 7));
// Console.WriteLine(FindQuarter(-6, 7));
// Console.WriteLine(FindQuarter(-4, -6));
// Console.WriteLine(FindQuarter(4, -6));
// Console.WriteLine(FindQuarter(0, -6));

void FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    Console.WriteLine($"Точка {x};{y} находится в 1 четверти");
else if (x < 0 && y > 0)
    Console.WriteLine($"Точка {x};{y} находится в 2 четверти");
else if (x < 0 && y < 0)
    Console.WriteLine($"Точка {x};{y} находится в 3 четверти");
else if (x > 0 && y < 0)
    Console.WriteLine($"Точка {x};{y} находится в 4 четверти");
else
    Console.WriteLine($"Точка {x};{y} находится на координатной оси");
}

FindQuarter(4, 7);
FindQuarter(-6, 7);
FindQuarter(-4, -6);
FindQuarter(4, -6);
FindQuarter(0, -6);