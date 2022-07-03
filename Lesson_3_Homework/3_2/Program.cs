// Программа, которая принимает на вход координаты двух точек и выводит расстояние
// между ними в 3D пространстве.
double dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}

Console.WriteLine(dist(3, 6, 8, 2, 1, -7));
Console.WriteLine(dist(7, -5, 0, 1, -1, 9));