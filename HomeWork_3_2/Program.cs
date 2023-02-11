// Подсчитать сумму цифр в числе.
int SumInt(string messange)
{
    Console.Write(messange);
    return int.Parse(Console.ReadLine()!);
}
int number = SumInt ($"Введите число у которого нужно посчитать сумму чисел из которых состоит число = ");
Console.Write($"Введеное число = {number}." );
int SumNumber = 0;
if (number < 0)number = number * -1;
    while (number > 0) 
    {
        
        SumNumber = SumNumber + number % 10;
        number = number /10 ;
    }
Console.WriteLine("Сумма чисел в числе равна = " + (SumNumber));

