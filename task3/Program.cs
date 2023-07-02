/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
void Cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.Write(i*i*i + ", ");
    }
}
int N = ReadInt("Введите число => ");
Cube(N);