/* Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.*/

/*
System.Console.WriteLine("Проверка треугольника на возможность существования.");
int a = InputNumberControl("Введите длину стороны А: ");
int b = InputNumberControl("Введите длину стороны B: ");
int c = InputNumberControl("Введите длину стороны C: ");
if (a > b + c || b > a + c || c > a + b)
{
    System.Console.WriteLine("Треугольника с указанными длинами сторон не существует.");
}
else System.Console.WriteLine("Такой треугольник существует.");
System.Console.WriteLine();
*/

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10  */

System.Console.WriteLine("Преобразование числа в двоичное.");
int num = InputNumberControl("Введите десятичное число, которое нужно преобразовать в двоичное: ");
DoubleNumber(num);

/*var d = 0b01010101;
System.Console.WriteLine(d);
System.Console.WriteLine(Convert.ToString(d, 2));
System.Console.WriteLine(d.GetType()); */

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

//Вывод в строку двоичного значения положительного числа.
void DoubleNumber(int number)
{
    if (number > 0)
    {
        System.Console.Write(number % 2);
        DoubleNumber(number / 2);
    }
}
