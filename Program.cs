
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

/*Console.WriteLine("Input treedidigitals number ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sot = (num1 / 100) ;
int dec = (num1 / 10);
int toodidjtl = dec % 10;

Console.WriteLine($"{toodidjtl} is too didjital from number");
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
/*

 int ThirdDidj(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Write("Input three didj number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDidj(number1) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Third didj is {ThirdDidj(number1)}");
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
/*
bool main (int num1)
{
  if(num1 == 6 || num1 == 7)
  {
    return true;
  }
  else
  {
    return false;
  }
}
Console.WriteLine($"{main(7)}");
*/


