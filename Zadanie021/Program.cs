/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int getCoord(string message)
{
  int result = 0;
  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Введено неверное число/символ. Попробуйте еще раз!");
    }
  }
  return result;
}

double getSize(int ax, int ay, int az, int bx, int by, int bz)
{
  double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
  // Длина отрезка в 3D - корень квадратный из ((x1-x2)^2+(y1-y2)^2+(z1-z2)^2)
  return result;
}

int ax = getCoord("Введите координату X первой точки");
int ay = getCoord("Введите координату Y первой точки");
int az = getCoord("Введите координату Z первой точки");

int bx = getCoord("Введите координату X второй точки");
int by = getCoord("Введите координату Y второй точки");
int bz = getCoord("Введите координату Z второй точки");


double size = Math.Round((getSize(ax, ay, az, bx, by, bz)), 2);

Console.WriteLine($"Расстояние между ({ax},{ay},{az}) и ({bx},{by},{bz}) is {size}");

