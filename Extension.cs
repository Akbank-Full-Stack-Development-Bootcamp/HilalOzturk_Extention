using System;
using System.Collections.Generic;
using System.Text;

namespace örnek.Extension
{
    public static class Extension
    {
        public static string deneme(this string a,string yazi)
        {
            yazi = yazi.ToLower();
            yazi = yazi.Replace('ö', 'o');
            yazi = yazi.Replace('ü', 'u');
            yazi = yazi.Replace('ğ', 'g');
            yazi = yazi.Replace('ş', 's');
            yazi = yazi.Replace('ı', 'i');
            yazi = yazi.Replace('ç', 'c');
            yazi = yazi.Replace(' ', '_');

            return yazi;

        }
    }
}
