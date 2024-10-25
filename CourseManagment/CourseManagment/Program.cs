using CourseManagment.Services;

namespace CourseManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CourseService courseService = new CourseService();

            string answer;

            do
            {
             
                Console.WriteLine("1.Grup yarat\n2.Gruplarin siyahisini goster\n3.Qrup uzerinda duzelish etmek\n4.Grup telebelerinin siyahisi\n5.All students\n6.Telebe yarat\n\n\n0.Cixish");
                answer =Console.ReadLine().Trim();

                switch (answer)
                {
                    case "1":

                        courseService.CreateGroup();
                        Console.WriteLine("Grup yarandi");


                        break;
                   case "2":

                        break;
                    case "3":

                        break;
                    case "0":

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Yanlish deyer");

                        break;
                }


                
            } while (answer!="0");
        }
    }
}
