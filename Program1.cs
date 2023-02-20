// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] MyArray = new int[5];
for (int i=0; i < 5; i++)
{
    Console.WriteLine("Please enter a " + (i + 1) + " number: ");
    MyArray[i] = Convert.ToInt32(Console.ReadLine());
}
if (MyArray[0] == MyArray[4] && MyArray[1] == MyArray[3])
{ Console.WriteLine("it's a palindrome!!!"); }
else
{
    Console.WriteLine("it's not a palindrome!!!");
}