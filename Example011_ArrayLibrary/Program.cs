//Метод (фунция) заполнение масива случайными другими числами
//void - Метод (фунция) не возвращает значение
void FillArray(int[] collection)      // FillArray"название метода"(int[] collection)"аргумент(collection-название )"
{
    int length = collection.Length;   // получаем длену массива "int length"-  название длены массива. "collection.Length" - длина (кол-во элементов)
    int index = 0;                    // позиция индекса указали по умолчанию 0
    while (index < length)           // цикл пока index меньше lengt (длина массива)
    {
        collection[index] = new Random().Next(1, 10);      // обращаемся к аргументу ""FillArray(int[] collection)" а именно collection" на позицию "index"index=0"" 
                                                           //и ложим туда новое случайное целое число из деапозона от 1 до 10 (1,9)
        index++;
    }
}

void PrintArray(int[] col)                     // Метод(фунция) кторая печатает массив, также задали новый аргумент "col"
{
    int count = col.Length;                    //Кол-во элементов
    int position = 0;                          // задали текущую позицию элемента
    while (position < count)
    {
        Console.WriteLine(col[position]);       // Выводим на эран термиала значение текущего элемента
        position++;
    }
}

int IndexOf(int[] collection, int find)     // Метод(фунция) нахождения позиции нужного элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];            // создать новый массив в котором будет 10 элементов (по умолчанию массв буде заполнени нулями)

FillArray(array);                    // Создаем и заполняем массив
PrintArray(array);                    // выводим массив на экран терминал
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);