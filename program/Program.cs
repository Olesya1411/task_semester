// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstArray = {"Hello", "2", "world", ":-)"};
string[] secondArray = new string[firstArray.Length];

void countArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
   
    for (int i = 0; i < firstArray.Length; i++)
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count ++;
        }
}
countArray(firstArray, secondArray);

Console.Write("[" + String.Join(", ", secondArray) + "]");
