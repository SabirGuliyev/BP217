using NullableStructEnum.Enums;
using NullableStructEnum.Models;
using System;

namespace NullableStructEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable
            //int? num =12;
            //string? name = null;
            //Console.WriteLine(num.HasValue); ;


            //if (num.HasValue)
            //{
            //    int num2 = num.Value;
            //    Console.WriteLine(num2);
            //}
            //else
            //{
            //    Console.WriteLine("Deyeri yoxdur");
            //}

            //Nullable<int> num2= null;



            //bool? status = null;
            //Nullable<bool> status2 = null;
            #endregion


            #region Struct

            //PointClass point = new PointClass { X = 3, Y = 2 };
            //point.X = 20;
            //Console.WriteLine(point.X);

            //PointStruct pointStruct = new PointStruct { X=3,Y=2};
            //pointStruct.X = 20;
            //Console.WriteLine(pointStruct.X);

            //Test(point);
            //Test(pointStruct);
            //Console.WriteLine(pointStruct.X); 
            #endregion

            #region Enum

            //foreach (WeekDay item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine((int)item + " " + item);
            //}

            //int num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case (int)WeekDay.Monday:
            //        Console.WriteLine(WeekDay.Monday);
            //        break;
            //    case (int)WeekDay.Tuesday:
            //        Console.WriteLine(WeekDay.Tuesday);
            //        break;
            //    //case (int)WeekDay.Wednesday:
            //    //    Console.WriteLine(WeekDay.Wednesday);
            //    //    break;
            //    case (int)WeekDay.Thursday:
            //        Console.WriteLine(WeekDay.Thursday);
            //        break;
            //    case (int)WeekDay.Friday:
            //        Console.WriteLine(WeekDay.Friday);
            //        break;
            //    case (int)WeekDay.Saturday:
            //        Console.WriteLine(WeekDay.Saturday
            //            );
            //        break;
            //    case (int)WeekDay.Sunday:
            //        Console.WriteLine(WeekDay.Sunday);
            //        break;

            //}

            //Person person = new Person(Gender.AustrianPainterWasRight);

            #endregion


            //Student student = new Student { Name="Azad", Fin="a"};
            //Student student2 = new Student { Name="Ayla", Fin="a1"};
            //Student student3 = new Student { Name="Ismayil", Fin="a2"};
            //Student student4 = new Student { Name="Mirdavud", Fin="a3"};

            //Group group = new Group { _students = new Student[] { student, student2, student3, student4 },Name="BP217" };


            //Student searchedStudent = group["a1"];
            //if(searchedStudent is null)
            //{
            //    Console.WriteLine("Telebe tapilmadi");
            //}
            //else
            //{
            //    Console.WriteLine(searchedStudent.Name);
            //}


            //this[int index]
            //group[1]


            //int[] nums = { 2, 3, 4, 5 };
            //Console.WriteLine(nums[0]);
            //nums[1] = 55;

          
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
       
            List<int> ints = new List<int> {1,2,3 };

            ints.Add(1);
            ints.Remove(1);

            CustomList<int> arr=new CustomList<int>(2,3,4,5);

            arr.Add(55);
            arr.Add(56);
            arr.Add(57);
            //Console.WriteLine(arr[0]);
            //arr[1] = 67;
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[50]);
            //arr[50] = 55;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            CustomList<string> words=new CustomList<string> ("salam","necesiz");

            words.Add("sabah");



        }

        //public static void Test(PointClass point)
        //{

        //}
        //public static void Test(PointStruct pointStruct)
        //{
        //    pointStruct.X = 30;
        //}
    }
}
