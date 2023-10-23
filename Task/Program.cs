// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//Задаем массив
string[] strArray = {"Hello", "2", "world", ":-)", "4"};

//
string[] userResArr = ThreeCharSort(strArray);
PrintResArr(userResArr);


//метод формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам
string[] ThreeCharSort(string[] arr){
    int count = 0;
    int resCount = 0;
    //считаем количество элементов не длиннее 3
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }

    }
    string[] resArray = new string[count];
    //заполняем массив уже известной длины
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resArray[resCount] = arr[i];
            resCount++;
        }

    }
    return resArray;
}

//печатаем массив
void PrintResArr(string[] resArr)
{
    for (int i = 0; i < resArr.Length; i++)
    {
        Console.Write(resArr[i] + " ");
    }
}
