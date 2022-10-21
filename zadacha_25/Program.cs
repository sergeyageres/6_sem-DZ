// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandomNumber(array);
Print(array);
int count = 0;
for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;
Console.WriteLine($"всего {array.Length} чисел, из них {count} чётных");
void RandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
     
    }   
}

