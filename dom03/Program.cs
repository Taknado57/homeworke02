// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = int.Parse(Console.ReadLine());

void CheckingTheDayOff (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOff(day);