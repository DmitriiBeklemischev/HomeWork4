// Если бы задача была бы без написания цикла, то программа выглядила бы так 

//Console.WriteLine("Введите чило");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите степень");
//int deg = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Pow(num, deg));

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите чило");
int num = int.Parse(Console.ReadLine());    //3
Console.WriteLine("Введите степень");
int deg = int.Parse(Console.ReadLine());    //5
int res = num;
for (int i = 2; i < deg + 1; i++)        //i=2  2<5 
{
    int n = res * num;               //  9 = 3*3
    res = num * res; 
    Console.WriteLine(n);                 
}

 Console.WriteLine($"Результат: {res}");
