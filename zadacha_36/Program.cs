//    Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandomNumber(array);
Print(array);
int count = 0;
int sum = 0;
for (int z = 0; z < array.Length; z++)
if (z % 2 == 1 || z == 1)
{
 sum = sum + array[z];
 count++;
}

Console.WriteLine($"всего {array.Length} чисел, из них {count} на нечётных позициях, сумма этих элементов равна= {sum}");

void RandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
     
    }   
}

