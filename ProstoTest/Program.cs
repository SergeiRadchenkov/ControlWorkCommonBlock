﻿/*
Просто Test
*/

int CheckNumber(int numb)
{
    while (numb < 3)
    {
        Console.WriteLine();
        Console.WriteLine($"Число {numb} меньше 3");
        Console.WriteLine("Задать массив не получится!");
        Console.WriteLine("Введите количество элементов массива: ");
        Console.WriteLine();
        numb = int.Parse(Console.ReadLine()!);
    }
    return numb;
}

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

string[] InputArray2(string[] array, int numb)
{
    string[] arr = new string[numb];
    int number;
    for (int i = 0; i < numb; i++)
    {
        number = new Random().Next(i, array.Length);
        arr[i] = array[number];
        array[number] = array[i];
        array[i] = arr[i];
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива,");
Console.WriteLine("число должно быть больше или равно 3: ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine()!);
n = CheckNumber(n);
string[] array= new string[n];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
n = new Random().Next(0, 4);
string[] newArray = InputArray2(array, n);
Console.WriteLine($"Итоговый массив: [{string.Join(", ", newArray)}]");
Console.WriteLine();