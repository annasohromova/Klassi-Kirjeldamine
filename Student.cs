using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Kirjeldamine
{
    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes => _likes;
        public DateTime Time => _time;
        public string Author => _author;
        public string Content => _content;

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsedSeconds = (DateTime.Now - _time).TotalSeconds;
            if (elapsedSeconds == 0)
            {
                return _likes;
            }
            return _likes / elapsedSeconds;
        }

        public static string GetPopularityInfo(Message message1, Message message2)
        {
            double popularity1 = message1.GetPopularity();
            double popularity2 = message2.GetPopularity();

            if (popularity1 > popularity2)
            {
                return $"{message1.Author}'s message is more popular than {message2.Author}'s message.";
            }
            else if (popularity2 > popularity1)
            {
                return $"{message2.Author}'s message is more popular than {message1.Author}'s message.";
            }
            else
            {
                return "Both messages have the same popularity.";
            }
        }

        public static Message GetMostPopularMessage(List<Message> messages)
        {
            if (messages.Count == 0)
            {
                throw new ArgumentException("The list of messages is empty.");
            }

            Message mostPopularMessage = messages[0];
            double highestPopularity = mostPopularMessage.GetPopularity();

            foreach (Message message in messages)
            {
                double popularity = message.GetPopularity();
                if (popularity > highestPopularity)
                {
                    mostPopularMessage = message;
                    highestPopularity = popularity;
                }
            }

            return mostPopularMessage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Content: {_content}");
            Console.WriteLine($"Time: {_time}");
            Console.WriteLine($"Likes: {_likes}");
        }
    }
}

//        public class Student
//        {
//            public string Name { get; }
//            public int age; 
//            private readonly string _city;
//            public string status;
//            public int birth;

//            public Student(string name, int age, string city)
//            {
//                Name = name;
//                Age = age;
//                _city = city;
//            }

            
//            public int Age
//            {
//                get { return age; }
//                set 
//                { 
//                    age = value;
//                    if (age < 18) status = "alaealine";
//                    else status = "taiskasvanud";
//                } 
//            }
            
//            public int Birth()
//            {
//            int aasta = DateTime.Now.Year - age;
//                return aasta;
//            } 
//            public string Status
//            {
//            get { return status; }    
//            }

//            public string GetCity()
//            {
//                return _city;
//            }
//            public void ShowInfo()
//            {
//                Console.WriteLine(Name);
//                Console.WriteLine(Age);
//                Console.WriteLine(GetCity());
//                Console.WriteLine(Status);
//                Console.WriteLine(birth);
//            }
//        }

