// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
Console.Write("Please enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

void KOOB(int[] number){
  int counter = 1;
  int length = number.Length;
  while (counter <  length){
    number[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void Print(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){Console.Write(coll[index]+ " "); index++; }
} 

int[] arry = new int[number+1];
KOOB(arry);
Print(arry);