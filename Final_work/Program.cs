// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
//  ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//  ["1234", "1567", "-2", "computer science"] -> ["-2"]
//  ["Russia", "Denmark", "Kazan"] -> []

string[] arrayFirst = new string[ ] { "1234", "1567", "-2", "computer science"};
string[] arraySecond = new string[arrayFirst.Length];
int count = 0;
for (int i = 0; i < arrayFirst.Length; i++)
{
    if (arrayFirst[i].Length <= 3)
    {
        arraySecond[count] = arrayFirst[i];
        count++;
    }
}
Console.WriteLine($"Заданный массив: [{string.Join(", ", arrayFirst)}]");
Console.WriteLine($"Полученный массив: [{string.Join(" ", arraySecond)}]");