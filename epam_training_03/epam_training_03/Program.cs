using System;
using System.Collections.Generic;
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
            Person person = new Person();
            person.Name = "Roman";
            person.Age = 19;
            person.PhoneNumbers = new List<string> { "+380677087158", "+380541211158", "+328067125612" };
            list.Add(person);
            Person person1 = new Person();
            person1.Name = "Ivan";
            person1.Age = 31;
            person1.PhoneNumbers = new List<string> { "+380642340433", "+380876545678", "+382067455622" };
            list.Add(person1);
            Person person2 = new Person();
            person2.Name = "Petro";
            person2.Age = 24;
            person2.PhoneNumbers = new List<string> { "+380123834568", "+380256462158", "+380664565663" };
            list.Add(person2);
            Person person3 = new Person();
            person3.Name = "Dabyd";
            person3.Age = 43;
            person3.PhoneNumbers = new List<string> { "+380534543158", "+380754567655", "+380757474848" };
            list.Add(person3);
            Person person4 = new Person();
            person4.Name = "Vasyl";
            person4.Age = 67;
            person4.PhoneNumbers = new List<string> { "+380676543345", "+380345124533", "+382343252316" };
            list.Add(person4);
            Person person5 = new Person();
            person5.Name = "Dabyd";
            person5.Age = 33;
            person5.PhoneNumbers = new List<string> { "+380936461233", "+380934252344", "+380673634634" };
            list.Add(person5);
            Person person6 = new Person();
            person6.Name = "Roman";
            person6.Age = 18;
            person6.PhoneNumbers = new List<string> { "+380675345352", "+380542353252", "+380671345546" };
            list.Add(person6);
            Person person7 = new Person();
            person7.Name = "Petro";
            person7.Age = 22;
            person7.PhoneNumbers = new List<string> { "+380672352551", "+380935141256", "+380671564457" };
            list.Add(person7);
            Person person8 = new Person();
            person8.Name = "Nazar";
            person8.Age = 28;
            person8.PhoneNumbers = new List<string> { "+380677533235", "+380543243241", "+380532563415" };
            list.Add(person8);
            Person person9 = new Person();
            person9.Name = "Andriy";
            person9.Age = 50;
            person9.PhoneNumbers = new List<string> { "+380672343265", "+380544565169", "+380674676882" };
            list.Add(person9);

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
            Person person = new Person();

            person.Name = "Yaroslav";
            person.Age = 21;
            person.PhoneNumbers = new List<string> { "+380675822111", "+380542342341", "+380282344231" };
            list2.Add(person);
            Person person2 = new Person();
            person2.Name = "Petro";
            person2.Age = 37;
            person2.PhoneNumbers = new List<string> { "+380634534521", "+380543454351", "+380275672234" };
            list2.Add(person2);

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
