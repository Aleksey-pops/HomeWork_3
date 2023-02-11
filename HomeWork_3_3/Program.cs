// Написать программу вычисления произведения чисел от 1 до N
int WorkNumber(string number)
{
    Console.Write(number);
    return int.Parse(Console.ReadLine()!);
}
int number = WorkNumber ("Введите число N = ");
for (int i = 1;i <= number;i++)
    Console.WriteLine($"Произведение чисел от одного до N: {i} \t{i * i}");

