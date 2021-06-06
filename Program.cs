using System;
using örnek.Extension;

namespace örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Türkçe karakteri, İngilizce Karaktere Çevirilecek yazıyı giriniz:");
            string str = Console.ReadLine();
            str = str.deneme(str);
            Console.WriteLine("İngilizce karakterlerden oluşan hali:\n"+str);
           
            Console.ReadLine();
        }
    }
}