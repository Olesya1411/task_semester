# Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм:
firstArray - задаётся массив строк, secondArray - то, куда будет записывааться новый массив.
В функции countArray в цикле for происходит проходка по всем элементам массива, в цикле if идёт сравнение строкового элемента, равен он или меньше 3 символов. Если да, то строковый элемент записывается в массив secondArray. И далее по остальным элементам.
Выводится в консоль массив secondArray.

### Блок-схема:
![блок-схема](task.jpg)