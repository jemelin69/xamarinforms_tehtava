using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinforms_tehtava
{
    public class User
    {
        private string name;
        private string address;
        private int age;

        public User(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return "Nimi: " + name + ", Ikä: " + age + ", Osoite: " + address;
        }
    }
}
