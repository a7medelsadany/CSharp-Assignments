namespace C_Sharp_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees[] EmpArr= new employees[3];
            EmpArr[0]=new employees(1,"ahmed",10000,privileges.DBA,'M',new HiringDate(2,4,2023));
            EmpArr[1]= new employees(2, "sara", 15000, privileges.guest, 'F', new HiringDate(5, 6, 2022));
            EmpArr[2] = new employees(3, "ali", 20000, privileges.secretary, 'M', new HiringDate(10, 12, 2021));
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
