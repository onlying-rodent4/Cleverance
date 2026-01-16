using Cleverence_1;
using System.Text.RegularExpressions;

Console.WriteLine("Введите строку нужного формата: " + Environment.NewLine + " - последовательно идущие строчные латинские буквы для сжатия" + Environment.NewLine +
                   " - последовательность строковых латинских букв и цифр для декомпрессии" + Environment.NewLine +
                   " - для выхода нажмите 1" + Environment.NewLine);


while (true)
{
    var Income_String = Console.ReadLine();
    if (Income_String == "1") break;


    if (Regex.IsMatch(Income_String, @"^[a-z]+$"))
    {
        Console.WriteLine(Environment.NewLine + "Сжатая строка: ");
        Console.WriteLine(StringBuild.Get_Compressed_string(Income_String) + Environment.NewLine);
    }
    else if (Regex.IsMatch(Income_String, @"^([a-z]\d*)+$"))
    {
        Console.WriteLine("Декомпрессионная строка: ");
        Console.WriteLine(StringBuild.Get_Decompressed_string(Income_String) + Environment.NewLine);
    }
    else
    {
        Console.WriteLine("Входная строки имеет неверный формат" + Environment.NewLine);
    }



}

