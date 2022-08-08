 // заполняем массив
 void FillArray(int[] collection)
        {
            int length = collection.Length; //длина нашего массива
            int index = 0; // берем позицию индекса и по умолчанию она будет начинаться с нуля
            while (index < length)
            {
                // обатиться к аргументу коллекция на позицию индект
                // и положить туда новое случайное число из диапозона 1...10
                collection[index] = new Random().Next(1, 10);
                index++;
                // в методе void мы ничего не возвращаем и не используем returm
            }
        }
// печать массива
void PrintArray(int[] col)
    {
        // обозначаем кол-во эл-тов
        int count = col.Length;
        int position = 0; //текущая позиция
        while (position < count)
        {
            Console.WriteLine(col[position]); //вывод на экран позицию текущего эл-та
            position++;
        }
    }
// описываем метод отличный от void. будет возвращать индекс
int IndexOf(int[] collection, int find) //в качестве аргумента
{
    int count = collection.Length;//определяем кол-во аргументов 
    int index = 0;
    int position = 0;//сохраняем найденную позицию
    while (index< count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;//возвращаем значение
}

int[] array = new int[10];

FillArray(array);
PrintArray(col);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);