// Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GetArray(int num)
{
    Random rnd = new Random();
    int [] array = new int[num];
    for (int i =0; i<array.Length; i++)
    {
        array[i]=rnd.Next(); 
    }
    return array;
}
int [] array = GetArray(8);

void WriteArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(", ");
        }
    }
    
    Console.Write(" -> [");
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
WriteArray(array);

// Тоже выведет также вместо WriteArray:
//Console.Write("{0}", string.Join(", ", array));
//Console.Write(" -> ");
//Console.Write("[{0}]", string.Join(", ", array));