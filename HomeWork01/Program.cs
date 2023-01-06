/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
* 0, 7, 8, -2, -2 -> 2
* 1, -7, 567, 89, 223-> 3 */

int[] myArray = {};
bool stop = false;
int count = 0;

while (stop == false)
{
    int temp = InputNumberControl("Вводите число либо нажмите Enter для выхода: ", out stop);
    if (stop) break;
    myArray = myArray.Append(temp).ToArray();
    if (temp > 0) count++;
}
Console.WriteLine();
Print1DArrayLine(myArray);
Console.WriteLine();
Console.WriteLine($"Вы ввели {myArray.Length} чисел, из них {count} больше 0.");
Console.WriteLine();

int InputNumberControl(string text, out bool stop)
{
    stop = false;
    System.Console.Write(text);
    int number;
    while (true)    
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number) || txt == "")
        {
             if (txt == "")
             {
                stop = true;
                break;
             }
             break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }  
    return number;
}

void Print1DArrayLine(int[] array)
{
    Console.WriteLine(string.Join(" | ", array));
}
