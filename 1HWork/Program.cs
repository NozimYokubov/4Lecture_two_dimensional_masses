// Мой не рабочий код
// string str = Console.ReadLine();
// string result = GetLettersFromString(str);

// Console.WriteLine(result);

// int GetNumFromString(string s)
// {
//     int size = 0;
//     int[] num = new int[s.Length];
//     {
//         foreach (char e in s)
//         {
//             if (char.IsDigit(e)) // Проверка, является ли символ цифрой
//             {
//                 num[size] = int.Parse(e.ToString()); // Преобразование символа в число и добавление его в массив
//                 size++; // Увеличение размера для следующего элемента
//             }
//         }
//     }
//     // Возвращаем размер массива, который будет равен количеству цифр
//     return size;
// }
// string str = Console.ReadLine();
// int result = GetNumFromString(str);
// Console.WriteLine(result);

// Ответ ChatGPT

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

List<int> digits = ExtractDigits(input);

Console.WriteLine("Массив цифр:");
Console.WriteLine("[" + string.Join(", ", digits) + "]");


static List<int> ExtractDigits(string input)
{
    List<int> result = new List<int>();

    foreach (char c in input)
    {
        if (char.IsDigit(c))
        {
            result.Add(int.Parse(c.ToString()));
        }
    }

    return result;
}

