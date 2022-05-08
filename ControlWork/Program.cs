string[] newArray = new string[] { "hello", "world", "2", ":-)", "34", "1333", "-2", "-13", "run", "fox", "dog" };

void PrintArray(string[] arr) // Метод распечатки массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int CountArray(string[] collection) // Метод подсчета длины валидного массива.
{
    int size = collection.Length; // Длина массива
    int counting = 0; // Переменная подсчета
    for (int i = 0; i < size; i++)
    {
        if (collection[i].Length <= 3) counting++;
    }
    return counting;
}
int count = CountArray(newArray);// Длина результирующего массива.
Console.WriteLine($"Длина результирующего массива: {count}");// Вывод подсчета, просто чтобы был перед глазами.

string[] GetValidArray(string[] array) //Метод создания массива валидных элементов.
{
    int size = array.Length;// Длина массива который был принят методом.
    string[] validArray = new string[count];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            validArray[j++] = array[i];
        }
    }
    return validArray;
}
string[] result = GetValidArray(newArray);
PrintArray(result);