// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 999);
Console.WriteLine("Сгенерировано случайное число : " + num);

int showNumber(int num1)
{
    int firstStep = num1 / 10;
    int secondStep = firstStep % 10;

    return secondStep;
}

Console.WriteLine("Вторая цифра числа: " + showNumber(num));