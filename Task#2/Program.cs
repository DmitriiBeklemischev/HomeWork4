//Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.


int sumEnd(int inum , int l) 
{
int sum = 0;
for (int i = l; i > 0; i--)
{
    int discharge = inum;
    discharge = discharge % 10;
    sum = sum + discharge;
    inum = inum / 10;
}
return sum;
}

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int len1 = num.Length;
int inum = int.Parse(num);

Console.WriteLine(sumEnd( inum , len1));

