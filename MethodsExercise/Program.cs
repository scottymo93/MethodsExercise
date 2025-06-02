namespace MethodsExercise
{
    public class Program
    {
        public static void GoodStory()
        {
            //questions and inputs
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("Type a verb.");
            string verb1 = Console.ReadLine();
            Console.WriteLine($"{name}, type a past tense verb");
            string verb2 = Console.ReadLine();
            
            //final story
            Console.WriteLine($"There once was a student named {name} whose favorite color was {color}." +
                              $" They always wanted a pet {animal} but couldn't afford it, so they ate {food} and kept dreaming." +
                              $" But then one day, {name} saw a huge {animal} {verb1} out from nowhere!" +
                              $" Terrified, {name} {verb2} off into the night. The End.");
        }
        static void Main(string[] args)
        {
          GoodStory();
        }
    }
}
