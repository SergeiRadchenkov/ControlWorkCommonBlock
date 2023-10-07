﻿/*
Написать программу, 
которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
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
    for (int i = 0; i < numb; i++)
    {
        
    }
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива,");
Console.WriteLine("число должно быть больше или равно 3: ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine()!);
n = CheckNumber(n);
string[] array = new string[n];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
n = new Random().Next(0, 4);
InputArray2(array, n);