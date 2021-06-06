using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VosrahSlova
{
    class Program
    { 
        public static string RemoveConsecDuplicates(string s) => Regex.Replace(s, @"(.)\1+", "$1");// заменяет строки


    
    
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//ввод текста
            VosratSlova(text);//вызов метода
            Console.ReadKey();


        }
        static void VosratSlova(string text)
        {
            string text2 = text.ToLower();//изменения текста под маленький шрифт


            Console.WriteLine(RemoveConsecDuplicates(text2));//вывод нового текста

        }
    }
}
