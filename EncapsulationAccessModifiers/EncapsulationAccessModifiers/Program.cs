using EncapsulationAccessModifiers.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EncapsulationAccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Record

            //Person person = new Person("Nurane","Valiyeva");
            //Person person2 = new Person("Nurane","Valiyeva");


            //PersonRecord personrec = new PersonRecord("Relax", "Valiyeva");
            ////personrec.Name = "Salam";

            //PersonRecord personrec2 = new PersonRecord("Nurane", "Valiyeva");
            //personrec2.Name = "Relax";
            //PersonRecord pers = new PersonRecord
            //{
            //    Name = "Ayxan",
            //    Surname = "Mammadli"
            //};
            //pers = pers with { Name = "Salam" }; 



            //Console.WriteLine(pers);

            #endregion

            #region Encapsulation
            //User user = new User("Sabir","Guliyev");


            //user.Password = Console.ReadLine();
            //user.Name = "Sabir";

            //user.Username = "killer71";
            //Console.WriteLine(user.Password);




            //user.GetInfo();
            //user.Name = "test";
            //user.Surname = "testov";
            //user.SetName("Sabir");
            //user.Surname = Console.ReadLine();

            //Console.WriteLine(user.GetName());



            //user.GetInfo();



            #endregion
            //object{0x001 31}
            //(string Name, int Day) month = ("Yanvar", 31);

            //(string Name, int Day) result = Tuple.Create("Yanvar", 31).ToValueTuple();


            //month.Item1 = "Fevral";
            //month.Item2 = 29;

            //month.Name = "Fevral";
            //month.Item2 = 29;


            //Console.WriteLine(month.Item1+" "+month.Item2);
            //int[] nums = { 12, 1, 13, 5, 4, 0, 9 };

            //var result = GetMinMax(nums);

            //Console.WriteLine(result.Min+" "+result.Max);

            //int a = 5;
            //int b = 10;

            //(a, b) = (b, a);

            //Console.WriteLine(a+" "+b);

            //if (true)
            //{
            //    Console.WriteLine("nese");
            //}

            //if(true)
            //    Console.WriteLine("Salam");

            //string a = " salam \"azad\" necesen?";


            //Console.WriteLine(a);

            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //string answer=Console.ReadLine().Trim().ToLower();

            //if (regex.IsMatch(answer))
            //{
            //    Console.WriteLine("Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong");
            //}

        }

        public static (int Min,int Max ) GetMinMax(int[] arr)
        {
            return (arr.Min(), arr.Max());
        }

        protected class User
        {


            //Access Modifiers/Specifiers

            private string _username;
            private string _name="xxx";
            public string Surname;
            private string _password="Welcome123!";

            
            public string Username
            {
                get
                {
                    return _username;
                }
              
            }
            public string Name { 
                get 
                {
                    return _name;
                }
                set 
                {
                    value = value.Trim();
                    if (value.Length >= 3 && value.Length <= 25)
                    {
                        _name = value;
                    }

                }
            
            }

            public string Password
            {
                set
                {
                    _password = value;
                }
            }

            public User(string name,string surname)
            {
               
                Name = name;
                Surname = surname;

                _username = string.Concat(name, ".", surname);

            }
            public string GetName()
            {

                return Name.ToLower();
            }

            public void SetName(string name)
            {
                name = name.Trim();
                if(name.Length>=3 && name.Length <= 25)
                {
                    Name = name;
                }

            }
            public void GetInfo()
            {
                Console.WriteLine($"Name:{Name} Surname:{Surname}");
            }
          
        }

        //class AdminUser : User
        //{
        //    public AdminUser()
        //    {
        //            Email = "sfdsf";
        //            Name = "ssad";
        //            Surname= "test";
        //        Console.WriteLine(Surname);
        //    }
        //}
    }
}
