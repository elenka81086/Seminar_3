/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/

double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

int Coordinate(string NewCoordinate, string SpotName)
{
    Console.Write($"Введите для {NewCoordinate} координату точки {SpotName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

int x1 = Coordinate("x1", "A");
int y1 = Coordinate("y1", "A");
int z1 = Coordinate("z1", "A");
int x2 = Coordinate("x2", "B");
int y2 = Coordinate("y2", "B");
int z2 = Coordinate("z2", "B");

double CutLength =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками составило {CutLength}");
