// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int[] FillArray(string message) 
{
    System.Console.WriteLine(message);
    var array = new int[2]; 

    System.Console.Write("Введите b: ");
    array[0] = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите k: ");
    array[1] = Convert.ToInt32(Console.ReadLine());

    return array;
}

bool CheckParallelism(int[] array1, int[] array2) 
{
    if (array1[1] == array2[1])
    {
        return true;
    }
    return false;
}

void IntersectionCoordinates(int[] array1, int[] array2) 
{
    double x = Math.Round((array2[0] - array1[0]) / (double)(array1[1] - array2[1]), 2);
    double y = array1[1] * x + array1[0];
    System.Console.WriteLine($"({x}; {y})");
}

int[] firstLineCoordinates = FillArray("Введите координаты 1ой прямой: ");
int[] secondLineCoordinates = FillArray("Введите координаты 2ой прямой: ");
if (CheckParallelism(firstLineCoordinates, secondLineCoordinates))
{
    System.Console.WriteLine("Прямые параллельны.");
} 
else
{
    IntersectionCoordinates(firstLineCoordinates, secondLineCoordinates);
}
