/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, *b2 и k2 задаются пользователем.
* b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

Console.Clear();
double K1 = InputNumberControl("Введите угловой коэффициент K для первой прямой: ");
double B1 = InputNumberControl("Введите коэффициент B для первой прямой: ");
double K2 = InputNumberControl("Введите угловой коэффициент K для второй прямой: ");
double B2 = InputNumberControl("Введите коэффициент B для второй прямой: ");
Console.WriteLine();
LineFunctionCrossPoint(K1, B1, K2, B2);
Console.WriteLine();

void LineFunctionCrossPoint(double K1, double B1, double K2, double B2)
{
    if (K1 == K2 && B1 != B2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if (K1 == K2 && B1 == B2)
    {
        Console.WriteLine("Прямые идентичны");
    }
    else
    {
        Console.WriteLine($"Прямые пересекаются в точке x = {(B2 - B1) / (K1 - K2)}; y = {K1 * ((B2 - B1) / (K1 - K2)) + B1}"); 
    }
}

//Метод контроль ввода целого числа
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