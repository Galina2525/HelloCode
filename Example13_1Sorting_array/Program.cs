// Сортируем массив от макс к мин используя метод
int[] arr = {3, 5, 7, 23, 16, 96, 5, 9};
void PrintArray(int[]array)
{    
    for(int i =0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[]array)
{
    for(int i =0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for(int j =i +1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        
        int temporary = array[i];
        array [i] = array[maxPosition];
        array[maxPosition] = temporary;
        
    }

}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);