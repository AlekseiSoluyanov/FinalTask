// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

// Метод принимает массив из строк от пользоваеля.
string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        newArray[i] = Convert.ToString(Console.ReadLine() ?? "0");
    }
    return newArray;
}

// Метод выводит в консоль полный массив строк
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

// Метод выводит в консоль массив строк, длина которых меньше, либо равна 3 символам
void ThreeSymbolsArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int len = 3;
        if (array[i].Length <= len)
            Console.Write(array[i] + ", ");
    }
}

Console.WriteLine("Введите длиму массива: ");
int InputArray = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(InputArray);
ShowArray(myArray);

Console.WriteLine("Массивы с тремя символами: ");
ThreeSymbolsArray(myArray);
Console.WriteLine();