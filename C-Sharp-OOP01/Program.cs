namespace Assignment01_OOP_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Assignment01 OOP
            #region Q1.weekdays
            //foreach (string days in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);
            //}
            #endregion
            #region Q2.struct person
            //Person[] persons= new Person[3];
            //persons[0].name = "ahmed";
            //persons[0].age = 22;

            //persons[1].name= "ali";
            //persons[1].age = 25;

            //persons[2].name = "omer";
            //persons[2].age = 30;

            //foreach(Person p in persons)
            //{
            //    Console.WriteLine($"Name: {p.name}, Age: {p.age}");
            //}
            #endregion
            #region Q3.seasons of the year
            //Season seasons = new Season();
            //Console.WriteLine("please enter month");
            //string? month = Console.ReadLine();
            //if (month == "march" || month == "april" || month == "may")
            //{
            //    Console.WriteLine($"the season is {Season.spring}");
            //}
            //else if(month== "june"||month=="jule"||month== "august")
            //{
            //    Console.WriteLine($"the season is {Season.summer}");
            //}
            //else if(month== "september" || month == "october" || month == "november")
            //{
            //    Console.WriteLine($"the season is {Season.autumn}");
            //}else if(month== "December "|| month== "january" || month == "february")
            //{
            //    Console.WriteLine($"the season is {Season.winter}");
            //}
            //else
            //{
            //    Console.WriteLine("invalid month");
            //}
            #endregion
            #region Q4.permissions
            //permissions permission= permissions.Read | permissions.Write;
            //Console.WriteLine(permission);
            //permission |= permissions.Delete;
            //Console.WriteLine(permission);
            //permission &= ~permissions.Write;
            //Console.WriteLine(permission);
            //if((permission & permissions.Read) == permissions.Read)
            //{
            //    Console.WriteLine("has permission read");
            //}
            //else
            //{
            //    Console.WriteLine("dosen't has permission read");
            //}if((permission&permissions.Execute)==permissions.Execute)
            //{
            //    Console.WriteLine("has permission execute");
            //}
            //else
            //{
            //    Console.WriteLine("dosen't has permission execute");
            //}
            #endregion
            #region Q5.colors
            //Console.WriteLine("please enter color");
            //bool isvalid = Enum.TryParse(Console.ReadLine(), out Colors color);
            //if (isvalid)
            //{
            //    Console.WriteLine($"{color} is primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not primary color");
            //}

            #endregion
            #region Q6.distance between two points
            //Console.WriteLine("please enter x1");
            //double.TryParse(Console.ReadLine(), out double x1);
            //Console.WriteLine("please enter y1");    
            //double.TryParse(Console.ReadLine(), out double y1);
            //Point point1 = new Point(x1,y1);

            //Console.WriteLine("please enter x2");
            //double.TryParse(Console.ReadLine(), out double x2);
            //Console.WriteLine("please enter y2");
            //double.TryParse(Console.ReadLine(), out double y2);
            //Point point2 = new Point(x2, y2);

            //double dx= point2.X - point1.X;
            //double dy=point2.Y- point1.Y;

            //double distance = Math.Sqrt(dx * dx + dy * dy);

            //Console.WriteLine($"the distance is {distance}");

            #endregion
            #region Q7.oldest person
            //Person[] p = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string? name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int.TryParse(Console.ReadLine(), out int age);

            //    p[i] = new Person(name, age);
            //}

            //Person oldest = p[0];

            //for (int i = 1; i < p.Length; i++)
            //{
            //    if (p[i].age > oldest.age)
            //    {
            //        oldest = p[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is: {oldest.name}, Age: {oldest.age}");

            #endregion 
            #endregion
        }
    }
}
