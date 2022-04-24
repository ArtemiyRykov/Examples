//ТИП ДАННЫХ[] ИМЯ = {значение1, значение2, ....}
// int[] array = {9, 28, 1, 32, 1990}

//int[] array = {0, 0, 0, 0, 0};
//int[] array = new int[5];
//int[] array = new int[]{0, 0, 0, 0, 0};
//int[] array = new int[5]{1, 0, 2, 0, 3};

int Max(int arg1, int arg2, int arg3) // Функция Мах (поиск максимальной из аргументов)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; // return возврат результата в Мах
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
//array[0] = 12; присвоить индексу [0] значение 12
//Console.WriteLine(array[4]); выввести на экран значение под индексом [4]

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);