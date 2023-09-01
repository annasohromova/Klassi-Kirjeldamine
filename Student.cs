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

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }

        public string GetPopularityInfo(double esimene, double teine)
        {
            string rezult = " ";
            if (esimene > teine) { rezult = "Esimene sõnum on populaarsem kui teine:"; };
            if(teine < esimene) { rezult = "Teine sõnum on populaarsem kui esimene"; };
            return rezult;
        }

        public string GetPopularityInfoN(List<Message> messages)
        {
            string rezult = "";
            double popularity = 0;
            for (int i = 0; 1 < messages.Count; i++)
            {
                if (messages[i].GetPopularity() > popularity)
                {
                    popularity = messages[i].GetPopularity();
                    rezult = messages[i].Content + " on kõige populaarsem sõnum, seda kirjutas" + messages[i].Author;
                }

            }
            return rezult;
        }
    

        public void ShowInfo()
        {
            Console.WriteLine(_author);
            Console.WriteLine(_content);
            Console.WriteLine(_time);
            
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

