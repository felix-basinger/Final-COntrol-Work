//  Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

int Length(string arg)
{
    int num;
    System.Console.Write($"Enter: {arg}: ");
    while(!int.TryParse(Console.ReadLine(), out num) || num < 1)
    {
        System.Console.WriteLine("It's not a number or incorrect data!");
        System.Console.Write($"Enter {arg}: ");
    }
    return num;
}

string[] CreateArray()
{
    System.Console.WriteLine("Hello!");
    int count = Length("How many elements do you want to see in your array? Your answer: ");
    string[] array = new string[count];
    return array;
}

 