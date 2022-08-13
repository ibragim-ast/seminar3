//Напишите программу, которая принимает на взод координаты двух точку и находит расстояние между ними в 
//3D пространстве

double FindDistance3D(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    double num1 = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));  
    return num1;
}

Console.WriteLine("Введите координаты Xa");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Ya");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Za");
double Za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Xb");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Yb");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Zb");
double Zb = Convert.ToDouble(Console.ReadLine());
double result = FindDistance3D(Xa, Ya, Za, Xb, Yb, Zb);
Console.WriteLine($"А я тебя нашел {result}");
