# Итоговая контрольная работа по основному блоку
## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:  
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## Решение:
1. Запустить программу коммандой "dotnet run".
2. Появится надпись: "Введите количество элементов массива, число должно быть больше или равно 3".
3. Необходимо ввести число больше или равно 3.
4. Если будет введено число меньше 3, программа попросит ввести число повторно.
5. Программа будет поочерёдно запрашивать ввод каждого элемента. Значение элемента может содержать цифры, символы и латинские буквы.
6. После ввода всех элементов массива программа выведет на экран весь массив.
7. Следующим этапом программа рандомно выберет число от 0 до 3 и выведет новый массив с размером согласно этому числу и рандомно выбранным элементам из начального массива. 

## Блок-схема
![Решение](Контрольная.png)