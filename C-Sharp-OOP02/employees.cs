using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP02
{
    internal class employees
    {
        public int id { get; set; }
        public string? name { get; set; }
        public decimal salary { get; set; }
        public privileges securityPrivileges { get; set; }

        public char gender;
        public HiringDate hiringDate { get; set; }
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("ivalid data");
                }
            }
        }

        public employees(int _id,string _name,decimal _salary,privileges _securityPrivileges,char _gender,HiringDate _hiringDate)
        {
            id= _id;
            name = _name;
            salary = _salary;
            securityPrivileges = _securityPrivileges;
            Gender= _gender;
            hiringDate = _hiringDate;
        }

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, Salary: {salary:C} , security privileges {securityPrivileges}" +
                $" , Gender {gender} , Hiring Date {hiringDate}";
        }
    }
  
}
