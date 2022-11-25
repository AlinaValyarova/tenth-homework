using System;
using System.Collections.Generic;
using System.Text;

namespace tumakov
{
    public class BCipher
    {
        public static void encode(string a)
        {
            char[] letters = new char[33] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            StringBuilder sb = new StringBuilder(a.ToLower());
            int len = sb.Length;
            for (int i = 0; i < len; i++)
            {
                int ind = Array.IndexOf(letters, sb[i]);
                Array.Reverse(letters);
                sb[i] = letters[ind];
            }
            Console.WriteLine(sb);

        }

        public static void decode(string a)
        {
            char[] letters = new char[33] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            Array.Reverse(letters);
            StringBuilder sb = new StringBuilder(a.ToLower());
            int len = sb.Length;
            for (int i = 0; i < len; i++)
            {
                int ind = Array.IndexOf(letters, sb[i]);
                Array.Reverse(letters);
                sb[i] = letters[ind];
            }
            Console.WriteLine(sb);
        }
    }
}
