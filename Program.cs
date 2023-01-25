string GetString()
{
    Console.Write("Для создания массива введите строки через запятую: ");
    string[] array = Console.ReadLine().Split(',');
    string rez = "";

    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            rez += item + ", ";
        }
    }

    rez = rez.TrimEnd(' ');
    rez = rez.TrimEnd(',');

    return rez;
}

string str = GetString();
string[] finalArray = str.Split(',');
Console.WriteLine("[" + str + "]");