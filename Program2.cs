// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int a1 = Coord("x", "A");
int b1 = Coord("y", "A");
int c1 = Coord("z", "A");
int a2 = Coord("x", "B");
int b2 = Coord("y", "B");
int c2 = Coord("z", "B");
int Coord(string CN, string PN)
{
    Console.Write($"Enter coordinate {CN} point {PN}: ");
    return Convert.ToInt16(Console.ReadLine());
}
                double Function(double a1, double a2, double b1, double b2, double c1, double c2)
                { return Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2-b1), 2) + Math.Pow((c2-c1), 2));}
double LineLength =  Math.Round (Function(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Segment length  {LineLength}");
