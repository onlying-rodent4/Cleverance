using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverence_1
{
    public static class StringBuild       
    {
        public static string? Compressed_string;             //поле хранящее готовую сжатую строку
        public static StringBuilder Decompressed_string;     //поле хранящее готовую декомпрессионную строку

        public static string Get_Compressed_string(string str )
        {
            char? symvol = null;
            int symvol_count = 0;
            foreach (var symv in str)
            {
                if (symvol == symv) { symvol_count++; }
                else
                {

                    StringBuild.Add_Item_To_Compressed_string(symvol, symvol_count);
                    symvol = symv;
                    symvol_count = 1;
                }

            }
            StringBuild.Add_Item_To_Compressed_string(symvol, symvol_count); //добавляем последний одиночный символd


            if (!String.IsNullOrEmpty(Compressed_string))
            {
                var TempString = Compressed_string;   //создаем временную переменную для возврата готовой строки
                Compressed_string = "";               //тут обнуляем для повторного использования
                return TempString;
                
            }
            else
                throw new Exception("Выходная строка пустая или равна null");
            
        }

        public static void Add_Item_To_Compressed_string(char? s, int c)   //метод добавления элементов в строку
        {
            string CountToAdd = (c == 1 || c==0) ? "" : c.ToString();
            string SymvToAdd = (s == null) ? "" : s.ToString();
            Compressed_string += SymvToAdd + CountToAdd;
        }

        public static string Get_Decompressed_string(string str)     //метод декомпрессии и возврата строки
        {
            Decompressed_string = new StringBuilder();
            for (int i=0; i<=str.Length-1; i++) 
            {
                if (i == str.Length - 1 || !char.IsDigit(str[i + 1]))
                {
                    Decompressed_string.Append(str[i]);
                }
                else
                {
                    Decompressed_string.Append(str[i], str[i + 1] - '0');
                    i++;
                }

            }

            if (!String.IsNullOrEmpty(Decompressed_string.ToString()))
                return Decompressed_string.ToString();
            else
                throw new Exception("Выходная строка пустая или равна null");
        }
    }
}
