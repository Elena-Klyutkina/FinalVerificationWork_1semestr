// Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3 символа.

// 1. Формируем массив строк
Console.WriteLine("Введите строки:");
int count = 0;
string[] array = new string[count];
string s = "";
string[] array2;

do
{
    s = Console.ReadLine();

    if (s != "")
    {
        count++;
        array2 = new string[count];

        for (int i = 0; i < array2.Length - 1; i++)
        {
            array2[i] = array[i];
        }
        array2[count - 1] = s;
        array = array2;

    }
}
while (s != "");

// 2. Ищем в имеющемся массиве элементы, у которых длина строки меньше либо равна 3 символа, и выводим на экран
for (int i = 0; i < array.Length; i++)
{
    int length = array[i].Length;
    if (length <= 3)
    {
        Console.WriteLine($"{array[i]} ");
    }
}