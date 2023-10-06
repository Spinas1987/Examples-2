// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecToBaseNum(int number, int baseNum)
{
    int result = 0;
    int mult = 1;
    while (number > 0)
    {
        result += number % baseNum * mult;
        number /= baseNum;
        mult *= 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите основане системы счисления");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int res = DecToBaseNum(number, baseNumber);
Console.WriteLine($"{number} - > {res}");