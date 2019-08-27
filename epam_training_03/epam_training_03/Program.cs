using System;
using System.Collections.Generic;
using System.Linq;
namespace epam_training_03
{
    class Program
    {
        public static void DisplayPage(ref List<string> Before, int pageNumber)
        {
            try
            {
                Console.WriteLine("Do u want to clear prev info? y/n");
                string n = Console.ReadLine();
                if (n == "y")
                {
                    Console.Clear();
                }
                const int number = 5;
                for (int i = pageNumber; i < pageNumber + number; i++)
                {
                    Console.WriteLine(Before[i]);
                }
            }catch(Exception)
            {
                Environment.Exit(1);
            }
        }
        private static void RemoveFrom(ref List<string> Before)
        {
            int i = 0, j = 0;
            bool Distinct = true;
            while (Distinct)
            {
                while (j < Before.Count - 1)
                {
                    ++j;
                    if (Before[i] == Before[j])
                    {
                        Before.Remove(Before[j]);
                        break;
                    }
                }
                if (Before[i][0] == 'Z')
                {
                    Before.Remove(Before[i]);
                }
                if (i == Before.Count - 1)
                {
                    Distinct = false;
                }
                ++i;
            }
        }
        private static void RandomGenerator(ref List<string> Before, int n)
        {
            Console.WriteLine();
            Console.WriteLine("Before transformation");
            int j = 0;
            while (j < n)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] Letters = new char[4];
                Random random = new Random();

                for (int i = 0; i < Letters.Length; i++)
                {
                    Letters[i] = chars[random.Next(chars.Length)];
                }

                string word = new String(Letters);
                Before.Add(word);
                ++j;
            }
        }
        private static void AddToPerson(ref List<Person> list)
        {
            list.Add(new Person());
            list.Last().Name = "Roman";
            list.Last().Age = 19;
            list.Last().PhoneNumbers = new List<string> { "+380677087158", "+380541211158", "+328067125612" };
            list.Add(new Person());
            list.Last().Name = "Ivan";
            list.Last().Age = 31;
            list.Last().PhoneNumbers = new List<string> { "+380642340433", "+380876545678", "+382067455622" };
            list.Add(new Person());
            list.Last().Name = "Petro";
            list.Last().Age = 24;
            list.Last().PhoneNumbers = new List<string> { "+380123834568", "+380256462158", "+380664565663" };
            list.Add(new Person());
            list.Last().Name = "Dabyd";
            list.Last().Age = 43;
            list.Last().PhoneNumbers = new List<string> { "+380534543158", "+380754567655", "+380757474848" };
            list.Add(new Person());
            list.Last().Name = "Vasyl";
            list.Last().Age = 67;
            list.Last().PhoneNumbers = new List<string> { "+380676543345", "+380345124533", "+382343252316" };
            list.Add(new Person());
            list.Last().Name = "Dabyd";
            list.Last().Age = 33;
            list.Last().PhoneNumbers = new List<string> { "+380936461233", "+380934252344", "+380673634634" };
            list.Add(new Person());
            list.Last().Name = "Roman";
            list.Last().Age = 18;
            list.Last().PhoneNumbers = new List<string> { "+380675345352", "+380542353252", "+380671345546" };
            list.Add(new Person());
            list.Last().Name = "Petro";
            list.Last().Age = 22;
            list.Last().PhoneNumbers = new List<string> { "+380672352551", "+380935141256", "+380671564457" };
            list.Add(new Person());
            list.Last().Name = "Nazar";
            list.Last().Age = 28;
            list.Last().PhoneNumbers = new List<string> { "+380677533235", "+380543243241", "+380532563415" };
            list.Add(new Person());
            list.Last().Name = "Andriy";
            list.Last().Age = 50;
            list.Last().PhoneNumbers = new List<string> { "+380672343265", "+380544565169", "+380674676882" };
        }
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>(10);
            AddToPerson(ref list);
            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item.Name + " Age: " + item.Age);
            }
            List<Person> list2 = new List<Person>(2);
            list2.Add(new Person());
            list2.Last().Name = "Yaroslav";
            list2.Last().Age = 21;
            list2.Last().PhoneNumbers = new List<string> { "+380675822111", "+380542342341", "+380282344231" };
            list2.Add(new Person());
            list2.Last().Name = "Petro";
            list2.Last().Age = 37;
            list2.Last().PhoneNumbers = new List<string> { "+380634534521", "+380543454351", "+380275672234" };
            list.AddRange(list2);
            foreach (var item in list)
            {
                foreach (var item1 in item.PhoneNumbers)
                {
                    Console.Write(item1 + " ");
                }
                Console.WriteLine();
            }
            List<string> Before = new List<string>(200);
            
            RandomGenerator(ref Before, 100);
            foreach (var item in Before)
            {
                Console.WriteLine(item);
            }
            RemoveFrom(ref Before);
            Console.WriteLine("After transformation");
            foreach (var item in Before)
            {
                Console.WriteLine(item);
            }
            
            int n;
            while (true)
            {
                try
                {
                    Console.WriteLine("Type page number");
                    n = Convert.ToInt32(Console.ReadLine());
                    DisplayPage(ref Before, n);
                }catch(Exception)
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
