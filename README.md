# Описание 
## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Решение:
1. Задается массив строковых элементов.
2. Создается метод, в котором считается сначала количество символов длинной не больше трех. Получаемое количество используется для создания нового массива в который заносятся сами элементы длиной не больше трех символов.
3. Содается метод для печати результирующего массива.
4. Вызываются методы.