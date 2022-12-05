/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

while (true) {
Console.WriteLine ("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 1000) == 0) 
{
    Console.WriteLine (number / 10 % 10);
    break;
} else 
{
    Console.WriteLine ("Число НЕ трехзначное!");
}
}