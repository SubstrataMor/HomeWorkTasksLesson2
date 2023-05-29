// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Start() // Метод ввода данных с возвращение числа, которое ввел пользователь
{
    Console.WriteLine("Введите число: ");   // Запрашиваем данные
    int number = Convert.ToInt32(Console.ReadLine());   // Преобразуем пользовательские данные в целое число
    return number;  // Возвращаем число
}
void Solution(int number)
{
    int num = number;
    if (num > 99)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        Console.WriteLine($"Третья цифра числа = {num % 10}");        
    }
    else if (num < -99)
    {
        num = number * (-1);
        while (num > 1000)
        {
            num = num / 10;
        }
        Console.WriteLine($"Третья цифра числа = {num % 10}");
    }
    else {Console.WriteLine("Третьей цифры нет");}
}
Solution(Start());