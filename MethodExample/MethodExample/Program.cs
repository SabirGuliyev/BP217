namespace MethodExample
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //int product = 90;
            //int discount = 10;
            //Console.WriteLine(product*discount/100);

            //int product2 = 120;
            //int discount2 = 20;
            //Console.WriteLine(product2*discount2/100);




            //int num=  GetDiscount(90,10);
            //Console.WriteLine(num);

            //  Console.WriteLine(GetDiscount(120, 20));

            //bool result = CheckAge(19);

            //CreateFullname();


            //GetSentence("Salam", "Gencler", "necesiz");
            //GetSentence("Hamimiz", "Kesilecik");

            //GetSentence();

            //int[] arr = { 1, 2, 3, 4 };
            //int[] arr2 = { 5, 6, 7 };

            //Console.WriteLine(ArrSum(arr));
            //Console.WriteLine(ArrSum(arr2));
            //Console.WriteLine(ArrSum(5,6,7,8,9,10));

            //Sum(1, 2);
            //Sum(3.2, 6.7);
            //Sum(1, 2,3,4);

            //Console.WriteLine();

            //Sum(1);
            //TakeFullname();

            int[] arr = { 2, 3, 4, 12, 16, 113 };

            Console.WriteLine(CheckCompositeArr(arr));


        }

        public static int CheckCompositeArr(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsComposite(nums[i]))
                {
                    count++;
                }
            }

            return count;
        }
        public static bool IsComposite(int num)
        {

            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    return true;
                }
            }

            return false;
        }



        //public static void TakeFullname()
        //{
        //    Console.WriteLine("Please enter your name:");
        //    string name=Console.ReadLine();

        //    Console.WriteLine("Please enter your surname:");
        //    string surname = Console.ReadLine();

        //    Console.WriteLine(name+" "+surname);

        //}

        //public static void Sum(params int[] nums)
        //{
        //    Console.WriteLine("3ci method");
        //}
        //public static void Sum(int num)
        //{
        //    Console.WriteLine("1ci method");
        //}

        //public static void Sum(int num, int num2=20)
        //{
        //    Console.WriteLine("2ci method");
        //}
      
       
        //public static void Sum(int num, int num2, int num3, int num4)
        //{
        //    Console.WriteLine("4ci method");
        //}





        public static void Sum(double num, double num2)
        {
            Console.WriteLine("2ci method");
        }


        public static void Sum(double num, int num2)
        {
            Console.WriteLine("1ci method");
        }
        public static void Sum(int num, double num2)
        {
            Console.WriteLine("1ci method");
        }



       




        public static int ArrSum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }





        public static void GetSentence(params string[] words)
        {
            string sentence = "";

            for (int i = 0; i < words.Length; i++)
            {
                sentence += words[i];
                sentence += " ";
            }

            Console.WriteLine(sentence);
        }






        public static void CreateFullname( string name="yyy",string surname = "xxx")
        {
            Console.WriteLine(name+" "+surname);
        }

        public static bool CheckAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            return false;
           
        }




        public static int GetDiscount(int price, int percent)
        {
            
            return price * percent / 100;

        }

        //public static void GetDiscount(int price,int percent)
        //{
        //    Console.WriteLine(price * percent / 100);
        //}

    }

}
