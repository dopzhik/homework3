﻿// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
/// Функция чтения с консоли числа
/// message - строка приглашения ввода для пользователя
// Возвращает целое значение, введенное пользователем
int ReadInt(string message)
{
    System.Console.Write(message);              // Выводим в консоль приглашение для ввода
    string inputedStr = Console.ReadLine();     // Вводим строку с консоли
    int number = Convert.ToInt32(inputedStr);   // Преобразует строку в целое значение
    return number;                              // Возвращает из функции значение
}

// Объявление функции
/// Проверка, что число 3-хзначное
bool Validate3Digits(int number)
{
    if (99 < number && number < 1000)   // 99 < number < 1000
    {
        return true;    // Проверка прошла успешно
    }
    System.Console.WriteLine("Число не трехзначное");    // проверка не прошла
    return false;
}

int num;    // Объявил переменную
num = ReadInt("Введите число > ");  // Ввод числа
if (Validate3Digits(num))
{
    int lastDigit = num % 10;
    System.Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
}