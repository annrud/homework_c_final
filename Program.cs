Console.Clear();
int maxLengthStr = 3;
Console.WriteLine("Программа преобразует исходный массив строк, " +
                  "в массив строк, длина которых меньше либо равна 3 символа.");
Console.Write("Введите количество элементов исходного массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите строки через ENTER: ");
string[] stringArray = CreateArray(arrLength);
Console.WriteLine("Исходный массив: [" + string.Join(", ", stringArray) + "]");
int lengthNewArr = GetLengthNewArray(maxLengthStr, stringArray);
string[] arrayResult = GetNewArray(lengthNewArr, maxLengthStr, stringArray);
Console.WriteLine("Результат: [" + string.Join(", ", arrayResult) + "]");


string[] CreateArray(int arrayLength)
{
    string[] arr = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        arr[i] = Console.ReadLine()!.Trim();
    }

    return arr;
}

int GetLengthNewArray(int maxLengthString, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthString)
        {
            count++;
        }
    }

    return count;
}

string[] GetNewArray(int lengthNewArray, int maxLengthString, string[] array)
{
    string[] newArray = new string[lengthNewArray];
    int j = 0;
    int k = 0;
    while (j < array.Length)
    {
        if (array[j].Length <= maxLengthString)
        {
            newArray[k] = array[j];
            k++;
        }
        j++;
    }

    return newArray;
}
