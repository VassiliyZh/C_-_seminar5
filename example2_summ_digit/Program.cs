// Задаем массив из случайных элементов. Вывести в консоль
// сумму элементов массива, расположенных на нечетных ячейках массива.

int[] CreateArray (int size) //Данная функция создает массив
{
    int[] createArray = new int[size];
    return createArray;
}
void FillArrayRandomNumbers (int[] array) //Функция заполняет массив случайными числами.
{
    Random rnd = new Random();

    for(int i=0; i<array.Length; i++)
        array[i] = rnd.Next(0,20);
}
string GetArrayInString(int[] array) // Созданный массив записывается в ввиде строки
{
    return String.Join(", ", array);
}
void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int OddCellsNumbers(int[] array)
{
    int summ = 0;
    for (int i = 1; i<array.Length; i=i+2)
    {
       summ += array[i];
    }
    return summ;
}

int size = 10;

int[] array = CreateArray(size);
FillArrayRandomNumbers (array);
PrintArray(array);

System.Console.WriteLine(OddCellsNumbers(array));