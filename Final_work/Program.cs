// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
//  ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//  ["1234", "1567", "-2", "computer science"] -> ["-2"]
//  ["Russia", "Denmark", "Kazan"] -> []

string[] arrayStart = new string[ ] { "1234", "1567", "-2", "computer science"};
string[] arrayEnd = new string[arrayStart.Length];
int count = 0;
for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrayStart[i].Length <= 3)
    {
        arrayEnd[count] = arrayStart[i];
        count++;
    }
}
Console.WriteLine($"Заданный массив: [{string.Join(", ", arrayStart)}]");
Console.WriteLine($"Полученный массив: [{string.Join(" ", arrayEnd)}]");