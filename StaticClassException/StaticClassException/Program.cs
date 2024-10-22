using StaticClassException.Models;
using StaticClassException.Utilities.Exceptions;
using System.Reflection;

namespace StaticClassException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Extension
            //Person person = new Person("saBiR");
            //string word = "Aqil";

            //word.Capitalize();
            //"salam".Capitalize();

            //int num = 2;

            //Console.WriteLine(num.Power(4));



            //Console.WriteLine(person.Name);


            //Console.WriteLine(Helper.OffEmail); 

            #endregion

            #region Exceptions
            //int num;
            //int num2;
            //try
            //{
            //    num = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(num/num2);
            //    string word = "Salam";
            //    //Console.WriteLine(word[50]);

            //}

            //catch (FormatException e)
            //{
            //    num = 1;
            //    num2 = 1;
            //    Console.WriteLine(e.Message);
            //}
            //catch(DivideByZeroException e)
            //{
            //    num2 = 1;
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Ne olur olsun ishe dushecek");
            //}



            //Console.WriteLine("Kod devam edir");



            //Person person;
            //Console.WriteLine("Please enter your name");
            //while (true)
            //{
            //    try
            //    {
            //       person = new Person(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception e)
            //    {


            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Please enter your name again");
            //    }
            //}


            //Console.WriteLine("Name:"+person.Name);
            //string search = "asdsadsadsadsad";


            //int a = 0;
            //try
            //{
            //    Console.WriteLine(Search(search));
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}


            //Console.WriteLine("kod devam"); 
            #endregion



            Assembly assembly=Assembly.GetExecutingAssembly();

            Type[] types=assembly.GetTypes();


            //FieldInfo
                //PropertyInfo
                //MethodInfo
                //ConstructorInfo
                //MemberInfo
          //foreach (Type type in types) {
          //      Console.WriteLine("---------------------------------");

          //      Console.WriteLine(type.Name);
          //      foreach (MemberInfo member in type.GetMembers()) 
          //      {
          //          Console.WriteLine(member.Name);
          //      }
          //  }
          


            //Teacher teacher = new Teacher { _name="Sabir"};
            //Type type = teacher.GetType();



            //Type type2 = typeof(Teacher);

            //Type type3 = assembly.GetType("StaticClassException.Models.Teacher");

            //Console.WriteLine();


            //FieldInfo field=type.GetField("_salary",BindingFlags.NonPublic | BindingFlags.Instance);


            //  field.SetValue(teacher, 123456.90m);

            //  //Console.WriteLine(field.GetValue(teacher));


            //  foreach (var item in type.GetMembers())
            //  {
            //      Console.WriteLine(item.Name);
            //  }





        }


        //public static string Search(string query)
        //{
        //    string[] arr = { "Mehin", "Kobra", "Ayxan", "Allahverdi" };

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == query)
        //        {
        //            return arr[i];
        //        }
        //    }
        //    throw new NotFoundException("Student was not found");

            
        //}
    }
}
