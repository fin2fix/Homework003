/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
  int resultNumber = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 9999 && resultNumber < 100000)
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

int number = GetNumber("Введите любое пятизначное число");

if (number % 10 == number / 10000 && number % 100 / 10 == number / 1000 % 10)
{
  Console.WriteLine($"Число {number} является палиндромом");
}
else
{
  Console.WriteLine($"Число {number} НЕ является палиндромом");
}

/* Второй вариант решения (с использованием введенного ранее метода GetNumber)

int number = GetNumber("Введите любое пятизначное число");
var array = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
if (array[0] == array[4] && array[1] == array[3])
{
  Console.WriteLine($"Число {number} является палиндромом");
}
else
{
  Console.WriteLine($"Число {number} НЕ является палиндромом");
}
*/