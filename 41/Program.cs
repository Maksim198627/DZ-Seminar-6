// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


System.Console.Write("Введите число элементов массива: ");// Ввод кол-ва элементов массива
int elcount = int.Parse(Console.ReadLine()!);
int[] array = Mass(elcount);
int count = PositiveNumbers(elcount);
System.Console.WriteLine();
System.Console.WriteLine("Кол-во положительных чисел в массиве: " + count);



int[] Mass(int elcount) // функция на рандомное заполнение массива
{
    int[] array1 = new int[elcount];
    Random random = new Random();
    System.Console.Write("Сформированный массив:");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = random.Next(-10, 30);
        System.Console.Write(array1[i]);

        if (i < array1.Length - 1) System.Console.Write(",");

    }
    return array1;

}

int PositiveNumbers(int elcount)
{
    int sum = 0;
    int[] arrab = new int[elcount];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }

    }
    return sum;

}