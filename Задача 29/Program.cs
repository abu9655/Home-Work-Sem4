//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Какой массив хотите");
Console.WriteLine("Варианты: 1:Рандомный  2:Последовательный");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int d = Convert.ToInt32(Console.ReadLine());
int x = 0;
Console.Write("[");
while (a==2&&d>x)
{
    x=x+1;
    Console.Write(x+" ");
}
if (a == 1)
{
    int[] array = new int[d];
    Random myRandom = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 20);
        Console.Write(array[i] + " ");

    }
    
}
if (a<=2)
{

}
else
{
    Console.Write("Нет такого варианта");
}
Console.Write("]");