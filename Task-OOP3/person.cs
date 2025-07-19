using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP03
{
    internal class person
    {
        private int id;
        private string? name;
        private string? email;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public string? Email
        {
            get { return email; }
            set { email = value; }
        }
        public person(int _id, string _name, string _email)
        {
            id = _id;
            name = _name;
            email = _email;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}");
        }

    }
}
