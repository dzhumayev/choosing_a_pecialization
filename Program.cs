using System.Text;

System.Console.Write("Введите элементы массива через запятую: ");
string[] sourceArray = Console.ReadLine().Split(',');

string[] resultArray = new string[0];
for (int i = 0; i < sourceArray.Length; i++)
{
        if (sourceArray[i].Length <= 3)
        {
            Array.Resize<string>(ref resultArray, resultArray.Length + 1);
            resultArray[resultArray.Length - 1] = sourceArray[i];
        }
}

printArray(resultArray);

void printArray(string[] array, char delimiter = ' ')
{

    if (array.Length == 0)
    {
        return;
    }
    
    StringBuilder sb = new StringBuilder();
    sb.Append(array[0]);

    for (int i = 1; i < array.Length; i++)
    {
        sb.Append($"{delimiter}{array[i]}");
    }

    System.Console.WriteLine(sb);
}
