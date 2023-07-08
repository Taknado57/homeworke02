//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Number = int.Parse(Console.ReadLine());
string NumberTop = Convert.ToString(Number);
if (NumberTop.Length > 2)
{
  Console.WriteLine("третья цифра -> " + NumberTop[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
