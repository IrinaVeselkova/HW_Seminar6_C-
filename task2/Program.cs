//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Ввод коэффициентов функции

double ReadInt(string msg)// объявляем функцию msg строковую
{
    Console.WriteLine(msg);//пишет на экран параметр msg
    string a = Console.ReadLine();
    double numb;
    numb = double.Parse(a);//преобразуем строку в число
    return numb;// возврат из функции
}
// находим точку пересечения в виде массива
double[] CrossFunctions(double k1, double b1, double k2, double b2)
{
    double[] arg = new double[2];
    arg[0] = (b2 - b1) / (k1 - k2);
    arg[1] = (k1 * arg[0] + b1);
    return arg;
}
// вывод точки пересечения
void printArray(double[] array)
{
    System.Console.Write($"({array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"; {array[i]}");
    }
    System.Console.WriteLine(")");
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("Чтобы высчитать точку пересечения двух прямых (у = kx+b), введите коэфициенты");
double k1 = ReadInt("Введите коэфициент k1 = ");
double k2 = ReadInt("Введите коэфициент k2 = ");
double b1 = ReadInt("Введите коэфициент b1 = ");
double b2 = ReadInt("Введите коэфициент b2 = ");
// проверка коэффициентов на значения
if (k1 == k2 || (k1 == 0 || k2 == 0))
{
    System.Console.WriteLine("Прямые не пересекаются, k1 и k2 не могут быть равны 0 или равны друг другу");
}
else
{
    if (b1 == 0 && b2 == 0)
    {
        System.Console.Write($"Прямые y={k1}*x и y={k2}*x пересекаются в точке (0;0)");
    }
    else
    {
        System.Console.Write($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2} пересекаются в точке ");
        printArray(CrossFunctions(k1, b1, k2, b2));
    }
}

