//Напишите программу, которая принимает на взод координаты двух точку и находит расстояние между ними в 
//3D пространстве

void FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double num1 = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));  
    Console.WriteLine(num1);
}

FindDistance(7, -5, 0, 1, -1, -9);
