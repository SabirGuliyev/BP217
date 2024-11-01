using SOLIDExamples.DIP;
using SOLIDExamples.Liskov;
using SOLIDExamples.OCP;

namespace SOLIDExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Knife knife=new Knife();
            Scissor scissor = new Scissor();
            Pizza pizza = new Pizza(scissor);

            pizza.CutPizza();







            //FlyShow<Eagle> flyShow = new FlyShow<Eagle>();
            //flyShow.StartShow();









            //Chef chef = new Chef();

            // MushedPotato meal = new MushedPotato();
            // FrenchFries meal2=new FrenchFries();
            // Soup meal3=new Soup();
            // chef.MakeMeal(meal);
            // chef.MakeMeal(meal2);
            // chef.MakeMeal(meal3);


            //chef.MushedPotato();
            //chef.FrenchFries();
        }
    }
}
