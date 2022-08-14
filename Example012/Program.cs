// Вид 1 - не пинимает никаких аргументов и ничего не возвращают
//void Mehood1() // ключевое слово void - Method - идентификатор метода
//{
//    Console.WriteLine("Автор ...");
//}
//Method1();


// Вид 2 - принимает какие-то аргументы, но ничео не возвращают. 
//void Method2(string msg) - в скобках аргументы
//{
//    Console.WriteLine(msg); - оператор в скобках указан принятый аргумент
//}
//Method2("Текст сообщения"); // идентификатор и выводимы метод

//void Method21(string msg, int count)
//{
//    int i = 0;
//    while (i < count) // переменая count отображает на экран кол-во сообщений msg
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
//}
//Method21(msg: "Текст", count: 4); //вызывает текст, после запятой кол-во вызовов.
///Method21(count: 4, msg: "новый текст"); //count - показывает кол-во сообщений.

//Вид 3 - может что-то возвращать, но не принимает никаких аргументов.

int Method3()
{
    return DateTime.Now.Year; //обязательно использование оператора return
}

int year = Method3(); // вызывает метод, в левой части используем идентификатор переменной(year), череч оператор = кладем нужное значение.
Console.WriteLine(year);


//Вид 4 - что-то принимает( аргум, данные). и что-то возвращает для дальнейшей работы.
string Method4(int count, string text) //возвращение строки string //,будем string компоновать друг за другом count раз.
{
    int i = 0;
    string result = String.Empty; //куда кладем результат

    while (i < count) //пока 
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf"); // значение кол-во склеиваний и текст
Console.WriteLine(res);


//Вид 5 - цикл for - собирает все в одном месте
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) //ключевое слово, затем счетчик, проверка условия и увеличение счетчика.
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

//цикл в цикле

for(int i =2; i<=10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}