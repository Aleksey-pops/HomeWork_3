// Найти кубы чисел от 1 до N.

int Readint(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int number = Readint ($"Введите число N до которого нужно отбразить кубы чисел N =   ");
int stepen = 3;


for (int i = 1; i <= number;number--)
{
   Console.WriteLine($"Заданное число возведенное в куб {number}: {number}^{stepen} = " + Math.Pow(number, stepen));
}