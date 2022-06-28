// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D 
// пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

пше 

Double Pifagor(int a1, int b1, int c1, int a2, int b2, int c2)
{
    Double Distance = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2));
    Distance = Math.Round(Distance,2);
    return Distance;

}
Double result = Pifagor(x1,y1,z1,x2, y2,z2);
Console.WriteLine(result);