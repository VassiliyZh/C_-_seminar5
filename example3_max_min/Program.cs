// Задаем массив из случайных элементов. Вывести в консоль
// разницу между максимальным и минимальным элементом массива.

int[] CreateArray (int size) //Данная функция создает массив
{
    int[] createArray = new int[size];
    return createArray;
}
void FillArrayRandomNumbers (int[] array) //Функция заполняет массив случайными числами.
{
    Random rnd = new Random();

    for(int i=0; i<array.Length; i++)
        array[i] = rnd.Next(5,20);
}
string GetArrayInString(int[] array) // Созданный массив записывается в ввиде строки
{
    return String.Join(", ", array);
}
void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int MaxMinNumber(int[] array, int max, int min)
{
    
    for (int i = 0; i<array.Length; i++)
    {
       if(max < array[i])
            max = array[i];
       if(min > array[i])
            min = array[i];
    }
    int result = max - min;
    return result;
}

int size = 10;
int max = 0;
int min = 20;
int[] array = CreateArray(size);
FillArrayRandomNumbers (array);
PrintArray(array);

System.Console.WriteLine(MaxMinNumber(array, max, min));