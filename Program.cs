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
            Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));

            m1.AddLike();
            m2.AddLike();
            m2.AddLike(); // Simulate more likes for m2

            Console.WriteLine("Message 1:");
            m1.ShowInfo();
            Console.WriteLine($"Popularity: {m1.GetPopularity()}");

            Console.WriteLine("\nMessage 2:");
            m2.ShowInfo();
            Console.WriteLine($"Popularity: {m2.GetPopularity()}");

            string popularityInfo = Message.GetPopularityInfo(m1, m2);
            Console.WriteLine($"\nPopularity Info: {popularityInfo}");

            List<Message> messages = new List<Message> { m1, m2 };
            Message mostPopular = Message.GetMostPopularMessage(messages);
            Console.WriteLine($"\nMost Popular Message:\n{mostPopular.Content} (Author: {mostPopular.Author})");
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
