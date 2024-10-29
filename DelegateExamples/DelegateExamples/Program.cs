using DelegateExamples.Models;
using System;
using System.Threading.Channels;

namespace DelegateExamples
{
    //public delegate bool CheckNum(int item);
    //public delegate void Print(string text);
    //public delegate void Test<T>(T item);
     internal class Program
    {
        
        static void Main(string[] args)
        {

            List<Student> students = new List<Student> {
            new Student{Name="Samurai", Surname="Samuraiova",Age=19,Grade=90 },
            new Student{Name="Relaxxx", Surname="Valiyeva",Age=19,Grade=61 },
            new Student{Name="True", Surname="False",Age=19,Grade=100 },
            new Student{Name="Kobra", Surname="Kuseyenova",Age=19,Grade=80 },
            new Student{Name="Special", Surname="One",Age=19,Grade=1 },
            new Student{Name="Mehin", Surname="Rehimle",Age=19,Grade=70 }
            };

            
            

           students= students.OrderByDescending(s => s.Grade).ToList();

            //students.RemoveAll(s => s.Grade == 1);

            students.ForEach(s => Console.WriteLine(s.Name + " " + s.Grade));


            

            //Console.WriteLine(student.Name);










            //Action<char, decimal, float> action = (x, y, z) => Console.WriteLine(x + " " + y);
            //Action test = () => Console.WriteLine("Salam");

            //Func<int,bool> func=x=>x > 5;

            //Predicate<int> predicate = x => x > 5;
            //Func<string, int> func = x => 5;

            //Func<char,string,int,bool> func2=(x,y,z)=> true;

            //Func<string> func3 = () => "Salam";




            //int[] nums = { 1, 2, 3, 4, 10, 14, 27 };



            //Console.WriteLine(Sum(nums, x => x % 3 == 0));
            //Console.WriteLine(Sum(nums, x => x % 7 == 0));
            //Console.WriteLine(Sum(nums,n=>n%2==0));


            //Test test = x =>x*x ;


            //Sum(nums, CheckEven);
            //Console.WriteLine(Sum(nums,CheckDivideThree));
            //Console.WriteLine(Sum(nums,CheckEven));
            //Console.WriteLine(Sum(nums,CheckOdd));


            //CheckNum seven = delegate (int num)
            //{
            //    return num % 7 == 0;
            //};

            //CheckNum greater = delegate (int num)
            //{
            //    return num > 2 && num < 10;
            //};


            //Console.WriteLine(Sum(nums, delegate (int num)
            //{
            //    return num % 7 == 0;
            //}));
            ////int result=Sum(nums, seven);
            ////Console.WriteLine(result);






            //string name = "sAbiR";
            //Action<string> print = PrintUpper;
            //print += PrintLower;
            //print += PrintCapitalize;
            //print -= PrintCapitalize;

            //print(name);




        }
       

        public static int Sum(int[] arr,Predicate<int> func)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (func(arr[i]))
                {
                    sum += arr[i];
                }
            }

            return sum; 
        }
        public static void PrintUpper(string name)
        {
            Console.WriteLine(name.ToUpper());
        }

        public static void PrintLower(string name)
        {
            Console.WriteLine(name.ToLower());
        }

        public static void PrintCapitalize(string word)
        {
            Console.WriteLine(Char.ToUpper(word[0]) + word.Substring(1).ToLower());
        }
        //public static bool CheckEven(int a)
        //{
        //    return a%2== 0;
        //}
        //public static bool CheckOdd(int b)
        //{
        //    return b % 2 != 0;
        //}
        //public static bool CheckDivideThree(int num)
        //{
        //    return num % 3 == 0;
        //}
    }
}
