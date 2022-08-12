void FindCoordinates(int quarter)
{
    if (quarter == 1)
    Console.WriteLine("x > 0, y > 0");
else if (quarter == 2)
    Console.WriteLine("x < 0, y > 0");
else if (quarter == 3)
    Console.WriteLine("x < 0, y < 0");
else if (quarter == 4)
    Console.WriteLine("x > 0, y < 0");
else
    Console.WriteLine("У нас всего 4 четверти");
}

FindCoordinates(1);
FindCoordinates(2);
FindCoordinates(3);
FindCoordinates(4);
FindCoordinates(0);

