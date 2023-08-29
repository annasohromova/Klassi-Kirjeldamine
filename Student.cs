using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Kirjeldamine
{
        public class Student
        {
            public string Name { get; }
            public int age; 
            private readonly string _city;
            public string status;
            public int birth;

            public Student(string name, int age, string city)
            {
                Name = name;
                Age = age;
                _city = city;
            }

            
            public int Age
            {
                get { return age; }
                set 
                { 
                    age = value;
                    if (age < 18) status = "alaealine";
                    else status = "taiskasvanud";
                } 
            }
            
            public int Birth()
            {
            int aasta = DateTime.Now.Year - age;
                return aasta;
            } 
            public string Status
            {
            get { return status; }    
            }

            public string GetCity()
            {
                return _city;
            }
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
                Console.WriteLine(GetCity());
                Console.WriteLine(Status);
                Console.WriteLine(birth);
            }
        }
}
