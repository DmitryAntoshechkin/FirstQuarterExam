

string[] GetArray(int number)
{
    string[] arr = new string[number];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int GetNumber(string message)
{
    bool error;
    int number;
    do
    {
        Console.Write(message);
        string input = Console.ReadLine();
        error = int.TryParse(input, out number);
        if (error == false)
        {
            Console.WriteLine("Ошибка ввода!");
        }
        else
        {
            if (number < 1)
            {
                Console.WriteLine("Введите число больше 0!");
            }
        }

    }
    while (error == false || number < 1);
    return number;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"'{arr[i]}', ");
    }
    if (arr.Length > 0) Console.WriteLine($"'{arr[arr.Length - 1]}']");
    else Console.WriteLine("]");

}

string[] GetSmallStrings(string[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            amount++;
        }
    }
    string[] result = new string[amount];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}

int size = GetNumber("Введите число элементов массива: ");
string[] array = GetArray(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
string[] newArray = GetSmallStrings(array);
Console.WriteLine("Строки не более трех символов:");
PrintArray(newArray);

