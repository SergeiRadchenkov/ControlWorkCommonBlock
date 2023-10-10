/*
Написать программу, 
которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

void InputArray(string[] array)
{
    string num;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Введите элемент массива № {i+1} из {array.Length},");
        Console.WriteLine("значение элемента может содержать цифры, символы и латинские буквы: ");
        Console.WriteLine();
        num = Console.ReadLine()!;
        array[i] = num;
    }
}

int InputArray2(string[] array, string[] arr, int numb)
{
    int count = 0;
    for (int i = 0; i < numb; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return count;
}

void PrintArray(string[] arr, int numb)
{
    string[] newArray = new string[numb];
    Console.WriteLine();
    for (int i = 0; i < numb; i++)
    {
        newArray[i] = arr[i];
    }
    Console.WriteLine($"Итоговый массив: [{string.Join(", ", newArray)}]");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine()!);
string[] array= new string[n];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
string[] newArray = new string[n];
int number = InputArray2(array, newArray, n);
PrintArray(newArray, number);
Console.WriteLine();