﻿// Упорядочить массивы

// Было: 6 8 3 2 1 4 5 7
// Результат: 1 2 3 4 5 6 7 8

int[] arr = {6, 8, 3, 2, 2, 1, 4, 5, 7};
//           0  1  2  3  4  5  6  7  8

void PrintArr(int[] array)
{
    int lenght = array.Length;
    for(int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++) //0...8
    {
        Console.WriteLine($"i->{i}");
        Console.WriteLine($"array.Length ={array.Length}");
        int minposition = i;
        Console.WriteLine($"minposition->{minposition}");
        for(int j = i + 1; j < array.Length; j++) //1...9
        {
            Console.WriteLine($"j={j}");
            Console.WriteLine($"array[j]->{array[j]}<array[minposition]->{array[minposition]}");
            if(array[j]< array[minposition])
            {
                Console.WriteLine($"if->{array[j]}<{array[minposition]}");
                minposition = j;
                Console.WriteLine($"minposition->{minposition}");

            }
        }
        int temp = array[i];
        Console.WriteLine($"temp={temp}");
        array[i] = array[minposition];
        Console.WriteLine($"array{i}={array[i]}");
        array[minposition] = temp;
        Console.WriteLine($"array{minposition}={array[minposition]}");
        Console.WriteLine();
    }

}

PrintArr(arr);
SelectionSort(arr);
PrintArr(arr);
