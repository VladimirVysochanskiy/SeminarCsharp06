/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
 */

//int N = InputNumberControl("Введите количество чисел Фибоначчи для вывода: ");
//Print1DArrayColumn(FibonacciLoop(N));

//Метод Числа Фибоначчи циклом в массив
/*int[] FibonacciLoop(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-2] + array[i - 1];
    }
    return array;
}*/
/*
int InputNumberControl(string text)
{
    System.Console.Write(text);
    int number;
    while (true)    
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number))
        {
             break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }  
    return number;
}
*/
void Print1DArrayLine(int[] array)
{
    Console.WriteLine(string.Join(" | ", array));
}
/*
void Print1DArrayColumn(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}*/

int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}

int[] CopyArrayEachItem(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}



/*Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.*/

Console.Clear();
const int ARRLENGTH = 20;
const int FROMNUM = -20;
const int TONUM = 20;

int[] myarray = RandArray(ARRLENGTH, FROMNUM, TONUM);
Print1DArrayLine(myarray);
System.Console.WriteLine();
int[] newArray = CopyArrayEachItem(myarray);
Print1DArrayLine(newArray);
