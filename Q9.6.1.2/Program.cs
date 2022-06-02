using System;

namespace Q9._6._1._2
{
    class Program
    {

        static string[] peopleList2 = new string[] { "Алексеев", "Бортунов", "Горунев", "Вересков", "Агониев" };
        static Sorter sort = new Sorter(peopleList2);
        static void Main(string[] args)
        {
            sort.SortList += ShowMas;
            try
            {
                sort.Reader();
            }
            catch (MyException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
       static public void ShowMas(int num)
        {
            switch (num)
            {
                case 1: sort.SortAZ(); break;
                case 2: sort.SortZA(); break;
            }
        }
    }


    public class Sorter
    {
        string[] peopleList2;

        public Sorter(string[] list)
        {
            peopleList2 = list;
        }

        public delegate void Sort(int num);
        public event Sort SortList;

        protected void SorterList(int num)
        {
            SortList?.Invoke(num);
        }
        public void Reader()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != 1 && num != 2) throw new FormatException();
            SorterList(num);
        }
        public void SortAZ()
        {
            Console.WriteLine("А-Я");
            Array.Sort(peopleList2);
            foreach (string str in peopleList2)
            {
                Console.WriteLine(str);
            }
        }
        public void SortZA()
        {
            Console.WriteLine("Я-А");  
            Array.Sort(peopleList2);
            Array.Reverse(peopleList2);
            foreach (string str in peopleList2)
            {
                Console.WriteLine(str);
            }
        }
    }
}
