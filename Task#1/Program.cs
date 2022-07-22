// Если бы задача была без написания цикла, то программа выглядила бы так: 

//Console.WriteLine("Введите чило");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите степень");
//int deg = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Pow(num, deg));

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите чило");
int num = int.Parse(Console.ReadLine());    
Console.WriteLine("Введите степень");
int deg = int.Parse(Console.ReadLine());    
int res = num;
for (int i = 2; i < deg + 1; i++)        
{   
    int n = res * num;               
    res = num * res;                 
}

 Console.WriteLine($"Результат: {res}");
