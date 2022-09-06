/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/



Console.Write("Введите число от 1-7: ");
int num = int.Parse(Console.ReadLine());

void Week(int num){


        switch (num)
                {
                case 1:
                    Console.WriteLine("Понедельник будни");
                    break;
            
                case 2:
                    Console.WriteLine("Вторник будни");
                    break;
            
                case 3:
                    Console.WriteLine("Среда будни");
                    break;
            
                case 4:
                    Console.WriteLine("Четверг будни");
                    break;
                
                case 5:
                    Console.WriteLine("Пятница будни");
                    break;
                
                case 6:
                    Console.WriteLine("Суббота выходной день");
                    break;
                
                case 7:
                    Console.WriteLine("Воскресение выходной день");
                    break;
                default:
                    Console.WriteLine("Вы ввели число не из диапазона 1-7. Повторите попытку");
                    break;
                }
}
Week(num);
