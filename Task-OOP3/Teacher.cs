using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP03
{
    internal class Teacher:person
    {
        public string? subject { get; set; }
        public Teacher(int _id,string _name,string _email,string _subject) : base(_id, _name, _email)
        {
            subject = _subject;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"ID : {Id},Name : {Name}, Email : {Email}, subject {subject}");
        }
    }
}
