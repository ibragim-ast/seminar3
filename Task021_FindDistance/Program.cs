void FindDistance(double xa, double ya, double xb, double yb)
{
    double num1 = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));  
    Console.WriteLine(num1);
}

FindDistance(3, 6, 2, 1);


