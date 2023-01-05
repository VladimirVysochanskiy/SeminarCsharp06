/* Напишите программу, которая перевернет  одномерный массив.
Последняя позиция становится первой и первая - последней.
*/

Console.Clear();
const int ARRLENGTH = 9;
const int FROMNUM = -10;
const int TONUM = 10;

int[] myarray = RandArray(ARRLENGTH, FROMNUM, TONUM);
Console.WriteLine(string.Join(" | ", myarray));
Console.WriteLine();
reverse1DArray(myarray);
Console.WriteLine(string.Join(" | ", myarray));

//метод создание и рандомное наполнение int массива (заданной длины, числами от, и до)
int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}

//метод реверса (переворота) одномерного массива.
void reverse1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1 - i; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length -1 - i] = temp;
    }
}
