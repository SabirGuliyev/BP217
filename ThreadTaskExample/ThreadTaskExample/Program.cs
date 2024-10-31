namespace ThreadTaskExample
{
    internal class Program
    {
       
        public static int Count=0;
        public static object LockObject=new();
        public static object LockObject2=new();
        static void Main(string[] args)
        {


            //Thread thread = new Thread(GetFirst);
            //Thread thread2 = new Thread(GetSecond);

            //thread.Start();
            //thread2.Start();


            //thread.Join();
            //thread2.Join();
            //Console.WriteLine("Bu main threadin kodudur gencler");

            //Console.WriteLine(Count);






            //Task task= Task.Run(() =>
            // {
            //     for (int i = 0; i < 10000; i++)
            //     {
            //         Console.WriteLine($"1-ci dovr donur{i}");
            //     }
            // });

            //Task task2= Task.Run(() =>
            // {
            //     for (int i = 0; i < 10000; i++)
            //     {
            //         Console.WriteLine($"2-ci dovr{i}");
            //     }
            // });


            // Task fullTask = Task.WhenAll(task, task2);

            // fullTask.Start();



            GetFirst(1);
            GetFirst(2);
            GetFirst(3);
            GetFirst(4);
            Console.ReadLine(); 


        }
        public static async Task GetFirst(int num)
        {


             await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine($"{num}-ci dovr donur{i}");
                }
            });
           





            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine($"1-ci dovr donur{i}");
            //    //lock (LockObject2)
            //    //{
            //    //    lock (LockObject)
            //    //    {
            //    //        Count++;
            //    //    }
            //    //}

            //}
        }
        public static void GetSecond()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"2-ci dovr {i}");
                //lock (LockObject)
                //{
                //    lock (LockObject2)
                //    {
                //        Count--;
                //    }
                //}

            }
        }
    }
}
