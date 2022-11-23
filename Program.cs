Console.Write("введите кол-во элементов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

string[] arrayresult = new string[n];
int len = 3;
int pos = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}


for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= len)
    {
        arrayresult [pos] = array[j];
        pos++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
PrintArray(arrayresult);
