
// Задайте массив заполненный случайными положительным трехзначными числами.
///Напишите программу, которая покажет количество четных чисел в массиве. 


Console.Write ("Введите количество элементов массива:");
int x=Convert.ToInt32 (Console.ReadLine());
int[] randomArray=new int[x];
void mas(int x)
{
    for (int i=0; i<x;i++)
{
randomArray[i]=new Random().Next(99,999);
Console.Write(randomArray[i]);
}
}
int kol   (int []randomArray)
{
int kol=0;
for ( int i=0; i<randomArray.Length;i++)

{
    if (randomArray[i]%2==0)
    kol=kol+1;
}
return kol;
}

mas(x);
Console.Write($"Количество четных чисел в массиве:{kol (randomArray)}");
