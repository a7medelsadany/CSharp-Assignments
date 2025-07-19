namespace Task_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person[] person1 = new person[4];
            person1[0] = new student(1, "ahmed", "@ahmed1", 22);
            person1[1] = new student(2, "mohamed", "@mohamed2", 23);
            person1[2] = new Teacher(3, "ali", "@ali3", "math");
            person1[3] = new AdminStaff(4, "elsadany", "@elsadany4", "admin");
            foreach(person p in person1)
            {
                p.GetDetails();
            }
        }
    }
}
