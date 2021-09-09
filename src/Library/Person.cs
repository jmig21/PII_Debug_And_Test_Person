using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fechaNac)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNac = fechaNac;
        }

        private string name;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string FechaNac
        {
             get
            {
                return this.FechaNac;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.FechaNac = value;
                }
            }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
