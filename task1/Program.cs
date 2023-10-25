//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// ввод массива
int[]  ReadMassive(string msg)// объявляем функцию msg строковую
{
    Console.WriteLine(msg);//пишет на экран параметр msg
    
    int[] massivNumbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();//преобразует массив из прлученной строки
    
    return massivNumbers;// возврат из функции
}

//вычисляем количество + элекментов массива

int CountPlusNumbers(int [] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item>0) count++;
    }
    return count;
}

int [] array = ReadMassive("Введите массив целых положительных и отрицательных числел через запятую");
System.Console.WriteLine($"Количество положительных цифр равно: {CountPlusNumbers(array)}");
