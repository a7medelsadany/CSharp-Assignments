namespace Assingnment06_C_sharp
{
    internal class Program
    {
        #region Assignment06-functions
        #region Q1.passing by value type(value,references)
        #region pass by value
        //public static void swap01(int x,int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #region pass by references
        //public static void swap02(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        #endregion
        #region Q2.passing by references type parameters
        #region pass by value
        //public static int sumArr( int[] array)
        //{
        //    int sum=0;
        //    if (array?.Length > 0)
        //    {
        //        for(int i = 0; i < array.Length; i++)
        //        {
        //            sum += array[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion
        #region pass by references
        //public static int sumArr01(ref int[] array)
        //{
        //    int sum = 0;
        //    if (array?.Length > 0)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            sum += array[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion
        #endregion
        #region ََQ3.sum and subtract
        //public static void sumandsub(int a, int b, out int sum,out int sub) { 
        //     sum = a + b;
        //     sub = a-b;
        //}   
        #endregion
        #region Q4.sum individual digits
        //public static int sumdig(int d)
        //{
        //    int sum = 0;
        //    int last = 0;
        //    for(int i=0; i < d; i++)
        //    {
        //       last= d % 10;
        //        sum += last;
        //        d /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region Q5.prime numbers
        //public static void IsPrime(int num)
        //{
        //    if (num > 1)
        //    {
        //        bool isPrime = true;

        //        for (int i = 2; i < num; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        }

        //        if (isPrime)
        //            Console.Write("true");
        //        else
        //        {
        //            Console.WriteLine("false");
        //        }
        //    }
        //}
        #endregion
        #region Q6.min and max number of array
        //public static void MinMaxArray(ref int[] array)
        //{
        //    int max=array.Max();
        //    int min=array.Min();
        //    Console.WriteLine($"the max number of array is : {max}");
        //    Console.WriteLine($"the min number of array is : {min}");
        //}
        #endregion
        #region Q7.factorial number
        //public static void factorial(int f)
        //{
        //    int res = 1;
        //    for(int i = 1; i <= f; i++)
        //    {
        //        res *= i;
        //    }
        //    Console.WriteLine(res);
        //}
        #endregion
        #region Q8.changeChar
        //public static void changeChar(string[] ch, string s, int position)
        //{
        //    if (position >= 0 && position < ch.Length)
        //    {
        //        ch[position] = s;
        //    }
        //    else
        //    {
        //        Console.WriteLine("invalid position");
        //    }

        //    for (int i = 0; i < ch.Length; i++)
        //    {
        //            Console.Write(ch[i]);
        //    }
        //}
        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region Assignment06 calling
            #region Q1.passing by value(value,references)
            #region pass by value calling
            //int a = 10, b = 20;
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");
            //swap01(a, b);
            //Console.WriteLine("after swap");
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");
            #endregion
            #region pass by references calling
            //int a = 10, b = 20;
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");
            //swap02(ref a,ref b);
            //Console.WriteLine("After swap");
            //Console.WriteLine($"a is {a}");
            //Console.WriteLine($"b is {b}");
            #endregion
            #endregion
            #region Q2.passing by references calling
            #region pass by value
            //int[] numbers = [1, 3, 5, 7];
            //int result = sumArr(numbers);
            //Console.WriteLine($"the result is {result}");

            #endregion
            #region pass by references
            //int[] numbers = [1, 3, 5, 7];
            //int result = sumArr01(ref numbers);
            //Console.WriteLine($"the result is {result}");
            #endregion
            #endregion
            #region Q3.sum and subtract
            //Console.WriteLine("please enter first number ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("please enter second number ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //sumandsub(num1, num2, out int sum, out int sub);

            //Console.WriteLine($"the sum is {sum}");
            //Console.WriteLine($"the subtract is {sub}");

            #endregion
            #region Q4.sum individual digits
            //Console.WriteLine("please enter numebr");
            //int.TryParse(Console.ReadLine(), out int num);
            //int res=sumdig(num);
            //Console.WriteLine(res);

            #endregion
            #region Q5.prime number
            //Console.WriteLine("please enter number");
            //int.TryParse(Console.ReadLine(), out int n);
            //IsPrime(n);
            #endregion
            #region Q6.min and max number of array
            //int[] numbers = [1, 2, 3, 4, 5, 7, 9];
            //MinMaxArray(ref numbers);
            #endregion
            #region Q7.factorial number
            //Console.WriteLine("please enter number");
            //int.TryParse(Console.ReadLine(), out int fact);

            //factorial(fact);
            #endregion
            #region Q8.changeChar
            //string[] chars = ["a ", " v ", " b ", " d"];
            //Console.WriteLine("please enter char");
            //string? s = Console.ReadLine();

            //Console.WriteLine("please enter position");
            //int.TryParse(Console.ReadLine(), out int position);
            //changeChar(chars, s,position);


            #endregion

            #endregion
        }
    }
}
