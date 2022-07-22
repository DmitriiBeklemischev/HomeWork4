//Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
int[] array = new int[8];
Console.WriteLine("Введите первое число массива:");
array[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число массива:");
array[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число массива:");
array[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число массива:");
array[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число массива:");
array[4] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите шестое число массива:");
array[5] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите седьмое число массива:");
array[6] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите восмое число массива:");
array[7] = int.Parse(Console.ReadLine());

for (int i = 0; i < 8; i++)
{
    Console.Write($" {array[i]}");
}