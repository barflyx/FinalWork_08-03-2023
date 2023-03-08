int GetLengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GetNewArray(string[] array, int length)
{
    string[] tmpArray = new string[length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tmpArray[index] = array[i];
            index++;
        }
    }
    return tmpArray;
}

string PrintArray(string[] array)
{
    string tmpValue = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) tmpValue += $"{array[i]}";
        else tmpValue += $"{array[i]}, ";
    }
    tmpValue += " ]";
    return tmpValue;
}

string[] stringArray = new string[] { "hello", "Hi", "222", "world" };

int lengthNewArray = GetLengthNewArray(stringArray);

if (lengthNewArray == 0) Console.WriteLine("В данном массиве нет значений подходящих под условие!");
else
{
    string[] newArray = GetNewArray(stringArray, lengthNewArray);
    Console.WriteLine(PrintArray(newArray));
}