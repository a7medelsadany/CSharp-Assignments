using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP03
{
    internal class AdminStaff:person
    {
        public string? role { get; set; }
        public AdminStaff(int _id,string _name,string _email,string _role) : base(_id, _name, _email)
        {
            role = _role;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"ID : {Id},Name : {Name}, Email : {Email}, role : {role}");
        }
    }
}
