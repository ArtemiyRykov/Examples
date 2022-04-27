// Вид 1
void Method1()  // Метод ничего не возвращает . Аргументов нет
{
    Console.WriteLine("Автор ...");
}
//Method1(); // вызов метода скобки обязательно


// Вид 2

void Method2(string msg) // Метод ничего не возвращает но может пренимать какието аргументы (1 аргумент)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");       // 1 способ вывод аргумента
//Method2(msg: "Текст сообщения"); // 2 способ вывода аргумента

void Method21(string msg, int count) // Метод ничего не возвращает но может пренимать какието аргументы (2 аргумента)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4); // Вывод 1 способ
//Method21(msg: "Текст", count: 4);  // Вывод 2 способ
//Method21(count: 4, msg: "Текст");  // Вывод 3 способ (поменяли местами аргументы)


// Вид 3

int Method3()    //Возвращаемый Метод (Обязательно указываем тип данных (int, string, double и т.д.) )  аргументы не указываем (в данном случае)
{
    return DateTime.Now.Year;     // обязательное использование операторв (return - возврат)
}
int year = Method3(); // вызываем метод(функцию)  указываем имя метода(Method3) круглые скобки, далее обязательно в левой части используе индефикатор переменной (int year) куда будет положено нужное значение
//Console.WriteLine(year); // Вывод метода

// Вид 4 

/*string Method4(int count, string text)    // Метод(фуеция) ,что-то принимамает, что-то возвращает
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка (string result = "")кавычки тоже обозначают пустую строку

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z"); // присваиваем митод(функцию) к переменной в скобках указывам вручную кол-во (10) выводов на экран, в кавачках "z" указываем текст для вывода вручную  
Console.WriteLine(res); // Вывод метода */


//  for на примере Method4

/*string Method5(int cound, string text)
{
    string result = String.Empty;
    for (int i = 0; i < cound; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "z"); // присваиваем митод(функцию) к переменной в скобках указывам вручную кол-во (10) выводов на экран, в кавачках "z" указываем текст для вывода вручную  
Console.WriteLine(res);*/


// Цикл в цикле ТАблица умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine( );
}
 
 
 
 
   */

//    Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.
// Ясна ли задача?

// Что значит “Дан текст”?. 
// Что значит “черточками”?
// Какого алфавита?
// Маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.
// Ясна ли задача?

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";


// string s == "qwert"
//              0123
// s[3] //r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;  // инициализация пустой строки 

    int length = text.Length;  // получили длину строки (кол-во символов в строке)
    for (int i = 0; i < length; i++) // циклом пробегаемся от нулевого символа до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текуций текст (text[i])совпал с символом который хотим заменить(oldValue) то в результат (result) кладем новое значение (newValue)
        else result = result + $"{text[i]}"; //еслежи совпадений не обнаружено в result добавляем текущий символ который и был        
    }
    return result;  // вернули рерузьтат
}

string newText = Replace(text, ' ', '|'); // присвоили Replace(text, ' ', '|')  это == Replace(string text (text), char oldValue (' ' он же пробел), char newValue ('|')) вывели текст и вместо пробелов поставели полочки
Console.WriteLine(newText);    
Console.WriteLine();   
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // завели массив

void PrintArray(int[] array) //метод для вывода на экран
{
    int count = array.Length; //получение кол-во элементов

    for (int i = 0; i < count; i++) //пробегаемся по всем элементам массива
    {
        Console.Write($"{array[i]} ");  // показываем на экране
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)  //метод упорядочивания массива
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minPosition = i; // определения позиции на которую смотрим

        for (int j = i + 1; j < array.Length + 1; j++)  //ищем минимальный элемент
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; // меняем позицию с которой нашли
        array[i] = array[minPosition]; // в рабочию позицию ([i]) кладем позицию которую нашли ([minPosition])
        array[minPosition] = temporary; // обмен переменных (temporary) временная переменная
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);