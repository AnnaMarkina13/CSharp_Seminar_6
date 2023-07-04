// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int ReadInt(string message) 
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int length) 
{
    var array = new int[length]; 

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0) count++;
    }
    return count;
} 

int length = ReadInt("Введите количество чисел, которое будете вводить: ");
int[] array = FillArray(length);
System.Console.WriteLine($"Количество введенных положительных чисел - {CountPositiveNumbers(array)}.");
