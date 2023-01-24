/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
  int resultNumber = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 1)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
      Console.WriteLine("-----------");
    }
  }
  return resultNumber;
}

void Cubelist(int digit)
{
  int cubeNumber = 0;
  for (int i = 1; i < digit; i++)
  {
    cubeNumber = i * i * i;
    Console.Write($"{cubeNumber}, ");
  }
  Console.Write($"{digit * digit * digit}.");
}

int number = GetNumber("Введите число больше 1");
Cubelist(number);

