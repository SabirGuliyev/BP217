
namespace StackHeapRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;

            //int b = a;

            //b = 20;
            //Console.WriteLine(a);

            //Console.WriteLine(a==b);

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;

            //Console.WriteLine(arr==arr2);
            //arr2[0] = 20;

            //Console.WriteLine(arr[0]);

            //Console.WriteLine(arr==arr2);






            //int[] numbers = { 5, 6, 7 };
            //ChangeIndex(numbers);

            //Console.WriteLine(numbers[0]);





            //int[] numbers = {1,2,3,4,5 };

            //ResetArray(ref numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}







            //int a=5;

            //ChangeValue(ref a);

            //Console.WriteLine(a);

            #region TryParse

            // Console.WriteLine("yashinizi daxil edin:");
            // string str=Console.ReadLine();

            // int age;

            //int.TryParse(str, out age);


            // Console.WriteLine(age); 
            #endregion


            #region ArrayResize

            //int[] numbers = { 1, 2, 3};

            //CustomArrayResize(ref numbers, 4,20,30,45,67);
            //CustomArrayResize(ref numbers, 20);

            //Array.Sort(numbers);
            ////Array.Resize(ref numbers, numbers.Length + 1);
            ////numbers[numbers.Length - 1] = 4;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion


        }

        public static void CustomArrayResize(ref int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1]; 


            for (int i = 0; i < arr.Length; i++)
            {

                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = num;


            arr = newArr;

        }



        //public static void ChangeValue(ref int num)
        //{

        //    num +=10;

        //    Console.WriteLine(num);
        //}



        public static void ResetArray(ref int[] arr)
        {
            arr = new int[arr.Length];

           
        }


        //public static void ChangeIndex(int[] arr)
        //{
        //    arr[0] += 40;
        //}

    }
}
