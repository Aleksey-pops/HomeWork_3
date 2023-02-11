// Показать кубы чисел, заканчивающихся на четную цифру

int Readint(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int number = Readint ($"Введите число N до которого нужно отобразить кубы чисел N = ");
for (int i = 0; i < number;number--)
    {
        double num2 = Math.Pow(number,3);
        if(num2 % 2 != 0)
        System.Console.WriteLine($"Число заканчивается на нечетную цифру = {number} \t{num2}");  
    }
 


