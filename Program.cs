using Klassi_Kirjeldamine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentMain
{
    public class Program
    {
        public static void Main()
        {
            Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
            Console.WriteLine("----------------------");
            m1.ShowInfo();
            m1.AddLike();
            Console.WriteLine(m1.GetPopularity());
            Console.WriteLine("----------------------");
            Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
            Console.WriteLine("----------------------");
            m2.ShowInfo();
            m2.AddLike();
            Console.WriteLine("----------------------");

            for (int i = 0; i < 1000; i++) { m2.AddLike(); }

            Console.WriteLine(m2.GetPopularity()); 
            Console.WriteLine(m1.GetPopularityInfo(m1.GetPopularity(), m2.GetPopularity()));
            Message m3 = new Message("Tere", "Mari", DateTime.Now.AddDays(-1));
            Message m4 = new Message("Guten Tag", "Hans", DateTime.Now.AddDays(-5));
            Message m5 = new Message("Hei", "Marika", DateTime.Now.AddDays(-10));
            List<Message> list = new List<Message>();
            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);
            Console.WriteLine(m1.GetPopularityInfoN(list));

        }
    }
}

//public static void Main()
    //{
    //    Student student = new Student("John", 17, "London");

    //    //Console.WriteLine(student.Name);
    //    //Console.WriteLine(student.Age);
    //    //Console.WriteLine(student.GetCity());
    //    student.ShowInfo();
    //}
