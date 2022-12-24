// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размерность массива (количество предполагаемых строковых значений): ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] FillArray(int n)
{
    Console.WriteLine("Начинайте ввод.");
    string[] arr = new string[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] ArrLengthThree(string[] arr)
{
    string[] arr2 = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
    arr2 = arr2.Where(x => x != null).ToArray();
    return arr2;
}

string[] array1 = FillArray(number);
Console.WriteLine("Исходный массив -> ");
PrintArray(array1);
string[] array2 = ArrLengthThree(array1);
Console.WriteLine("Итоговый массив -> ");
PrintArray(array2);
