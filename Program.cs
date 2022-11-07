//======================================================================
// Программа из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомедуется пользоваться коллекциями, лучше обойтись
//  исключительно массивами.
//=======================================================================
// Считываем данные
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Формирование строкового массива
string[] GenArray(int arrayLength)
{
    Console.WriteLine("Введите элементы массива");
    string[] array = new string[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine() ?? "0";
    }
    return array;
}

// Формируем массив
string[] ResultArray(string[] array)
{
    string resString = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resString = resString + array[i] + ",";
        }
    }
    resString = resString.TrimEnd(',');
    array = resString.Split(',').ToArray();
    return array;
}

//Печатаем одномерного массива
void PrintArray(string[] array)
{
    Console.Write("[" + array[0] + ",");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}

int arrayLength = ReadData("Введите длину массива");
string[] array = GenArray(arrayLength);
if (ResultArray(array).Length > 1)
{
    Console.WriteLine("Итоговый массив с элементами, количество символов в которых <= 3");
    PrintArray(ResultArray(array));
}
else
{
    Console.WriteLine("[]");
}

