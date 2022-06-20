using System;
using static System.Console;
using  System.Collections;
using System.Collections.Generic;

namespace Slovar
{
    class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
        public override string ToString()
        {
            return $"x={X} y={Y}";
        }
    }
    class CountWords
    {
        private static Dictionary<string, uint> d;

        public
        CountWords()
        {
            d = new Dictionary<string, uint>();
        }

        public void
        AddWord(string word)
        {
            if (d.ContainsKey(word))
            {
                d[word] += 1;
            }
            else
            {
                d.Add(word, 1);
            }
        }

        public void
        PrintStats()
        {
            foreach (var i in d)
            {
                Console.WriteLine($"Word {i.Key} appears {i.Value} times.");
            }
        }
    }
    class Point3D : Point2D<int>
    {
        int Z;
        public Point3D(int x1,int y1,int z1)
        {
            X = x1;
            Y = y1;
            Z = z1;
        }
        public override string ToString()
        {
            return $"x={X} y={Y} z={Z}";
        }

    }
    class Line 
    {
        Point2D<int> p1;
        Point2D<int> p2;
        public Line(int x1, int y1)
        {
            p1 = new Point2D<int>(x1,y1);
        }
        public Line(int x1, int y1,int x2, int y2)
        {
            p1 = new Point2D<int>(x1, y1);
            p2 = new Point2D<int>(x2, y2);
        }
        public override string ToString()
        {
            return $"Первая точка  {p1.ToString()}      Вторая точка  {p2.ToString()}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите название страны которую желаете перевести");
            string perevod = ReadLine();
            SortedList Country = new SortedList();
            Country.Add("Россия", "Russia");
            Country.Add("Москва", "Moscow");
            Country.Add("США", "USA");
            Country.Add("Вашингтон", "Washington");
            Country.Add("Китай", "China");
            Country.Add("Пекин", "Beijing");
            Country.Add("Великобритания", "Great Britain");
            Country.Add("Австралия", "Australia");
            Country.Add("Албания", "Албания");
            Country.Add("Бельгия", "Belgium");
            Country.Add("Болгария", "Bulgaria");
            Country.Add("Грузия", "Georgia");
            Country.Add("Гуам", "Guam");
            Country.Add("Египет", "Egypt");
            Country.Add("Замбия", "Zambia");
            Country.Add("Израиль", "Israel");
            Country.Add("Индия", "India");
            Country.Add("Индонезия", "Indonesia");
            Country.Add("Иордания", "Jordan");
            Country.Add("Иран", "Iran");
            Country.Add("Италия", "Italy");
            Country.Add("Йемен", "Yemen");
            Country.Add("Казахстан", "Kazakhstan");
            Country.Add("Корея Южная", "Korea");
            Country.Add("Латвия", "Latvia");
            Country.Add("Ливия", "Lithuania");
            Country.Add("Люксембург", "Luxembourg");
            Country.Add("Гана", "Ghana");
            Country.Add("Германия", "Germany");
            Country.Add("Гренада", "Grenada");
            Country.Add("Доминика", "Dominica");
            Country.Add("Катар", "Qatar");
            Country.Add("Кипр", "Cyprus");
            Country.Add("Колумбия", "Colombia");
            Country.Add("Коста-Рика", "Costa Rica");
            Country.Add("Либерия", "Liberia");
            Country.Add("Лихтенштейн", "Liechtenstein");
            Country.Add("Маврикий", "Mauritius");
            Country.Add("Монако", "Monaco");
            Country.Add("Монголия", "Mongolia");
            Country.Add("Норвегия", "Norway");
            Country.Add("Оман", "Oman");
            Country.Add("Перу", "Peru");
            Country.Add("Нигер", "Niger");
            Country.Add("Нигерия", "Nigeria");
            Country.Add("Нидерланды", "Netherlands");
            Country.Add("Никарагуа", "Nicaragua");
            Country.Add("Парагвай", "Paraguay");
            Country.Add("Сенегал", "Senegal");
            Country.Add("Сербия", "Serbia");
            Country.Add("Сирия", "Syrian");
            Country.Add("Словакия", "Slovakia");
            Country.Add("Словения", "Slovenia");
            Country.Add("Сомали", "Somalia");
            Country.Add("Судан", "Sudan");
            Country.Add("Таджикистан", "Tajikistan");
            Country.Add("Таиланд", "Thailand");
            Country.Add("Танзания", "Tanzania");
            Country.Add("Того", "Togo");
            Country.Add("Тунис", "Tunisia");
            Country.Add("Туркменистан", "Turkmenistan");
            Country.Add("Турция", "Turkey");
            Country.Add("Уганда", "Uganda");
            Country.Add("Узбекистан", "Uzbekistan");
            Country.Add("Украина", "Ukraine");
            Country.Add("Уругвай", "Uruguay");
            Country.Add("Фиджи", "Fiji");
            Country.Add("Филиппины", "Philippines");
            Country.Add("Финляндия", "Finland");
            Country.Add("Франция", "France");
            Country.Add("Хорватия", "Croatia");
            Country.Add("Чад", "Chad");
            Country.Add("Черногория", "Montenegro");
            Country.Add("Чехия", "Czech");
            Country.Add("Чили", "Chile");
            Country.Add("Швейцария", "Switzerland");
            Country.Add("Швеция", "Sweden");
            Country.Add("Эквадор", "Ecuador");
            Country.Add("Эритрея", "Eritrea");
            Country.Add("Эстония", "Estonia");
            Country.Add("Эфиопия", "Ethiopia");
            Country.Add("ЮАР", "South Africa");
            Country.Add("Ямайка", "Jamaica");
            Country.Add("Япония", "Japan");
            foreach (object ite in Country.Keys)
            {
                if (Country[ite].ToString() == perevod)
                {
                    WriteLine($"Перевод: { ite}");
                }
            }

            foreach (object item in Country.Keys)
            {
                if (item.ToString() == perevod)
                {
                    WriteLine($"Перевод: { Country[item]}");
                }
            }


            //WriteLine("Введите текст");
            //string text = ReadLine();
            //char[] delimiters = { ' ', ',', '.' };
            //string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            //CountWords cw = new CountWords();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    cw.AddWord(words[i]);
            //}
            //cw.PrintStats();

            //Point3D p = new Point3D(4, 5, 6);
            //WriteLine(p);

            //Line l = new Line(4,5,6,7);
            //WriteLine(l);
        }
    }
}
