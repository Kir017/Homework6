// Домашнее задание № 6 по курсу: Знакомство с языками программирования (семинары)
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateFillArray()
{
    Console.Write("Введите количество чисел: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void CountPositiveNumber(int[] colection)
{
    int count = 0;
    for (int i = 0; i < colection.Length; i++)
    {
        if (colection[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 -> {count}");
}

int[] arrayNumbers = CreateFillArray();
CountPositiveNumber(arrayNumbers);

