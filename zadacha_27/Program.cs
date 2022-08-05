//Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int Addition (int number)
{
    int sum = 0;
    while(number>0)
    {
        int rem=number%10;
        sum = sum+rem;
        number = number/10;
    }
    return sum;
}

int result = Addition(num);
Console.WriteLine ($"{num} -> {result}");