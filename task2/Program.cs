﻿/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
double Range3D(int x1, int y1, int z1, int x2, int y2, int z2)
{  
int rangex = x1 - x2;
int rangey = y1 - y2;
int rangez = z1 - z2;
double range = Math.Sqrt(rangex*rangex + rangey*rangey + rangez*rangez);
return range;
}
int x1 = ReadInt("Введите x1 => ");
int y1 = ReadInt("Введите y1 => ");
int z1 = ReadInt("Введите z1 => ");
int x2 = ReadInt("Введите x2 => ");
int y2 = ReadInt("Введите y2 => ");
int z2 = ReadInt("Введите z2 => ");
System.Console.WriteLine($"Расстояние между координатами равно {Range3D(x1, y1, z1, x2, y2, z2)}");