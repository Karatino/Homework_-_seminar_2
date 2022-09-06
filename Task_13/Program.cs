// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// то третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число состоящие из трех или более знаков: ");
int num = int.Parse(Console.ReadLine());

void Third_digit(int num){

if (num > 99 || num < -99)

    {
        while (num > 1000)
        {
            num = num / 10;
        }
        int result = num % 10;
        Console.WriteLine($"Третья цифра числа = {result}");
    }


else 
    {
        Console.WriteLine($"Третьей цифры нет");
    }
}
Third_digit(num);
