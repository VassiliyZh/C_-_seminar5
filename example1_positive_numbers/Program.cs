// Задаем массив из трехзначных случайных элементов. Вывести в консоль
// общее количество четных элементов массива.

int[] CreateArray (int size) //Данная функция создает массив
{
    int[] createArray = new int[size];
    return createArray;
}
void FillArrayRandomNumbers (int[] array) //Функция заполняет массив случайными числами.
{
    Random rnd = new Random();

    for(int i=0; i<array.Length; i++)
        array[i] = rnd.Next(100,1000);
}
string GetArrayInString(int[] array) // Созданный массив записывается в ввиде строки
{
    return String.Join(", ", array);
}
void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
       if(array[i]%2 == 0)
            count++;
    }
    return count;
}

int size = 12;

int[] array = CreateArray(size);
FillArrayRandomNumbers (array);
PrintArray(array);

System.Console.WriteLine(EvenNumbers(array));
