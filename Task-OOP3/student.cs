using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP03
{
    internal class student:person
    {
        public int GradeLevel { get; set; }

        public student(int _id, string _name, string _email, int _gradeLevel) : base(_id, _name, _email)
        {
            GradeLevel = _gradeLevel;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"ID : {Id},Name : {Name}, Email : {Email}, grade level:{GradeLevel}"); 
        }
    }
}
