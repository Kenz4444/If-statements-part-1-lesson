using System.Reflection.PortableExecutable;

namespace If_statements_part_1_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Task1(); 
            //Task2();
            //Task3();
            Task4();
        }
            
        static void Task1()
        {
            int people = 20;
            int cats = 20;
            int dogs = 15;
            Console.WriteLine("People: " + people + " Dogs: " + dogs +" Cats: " +cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats, the world is doomed!");
                }
            if (people > cats)
            {
                Console.WriteLine("Not as many cats! how beautiful");
                }
            if(people < dogs)
            {
                Console.WriteLine("I love dogs");
            }
            if (dogs>people)
            {
                Console.WriteLine("Ew people");
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people>= dogs)
            {
                Console.WriteLine("People are equal to or greater than dogs");

            }
            if (people<= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs");
            }
            if (people==dogs)
            {
                Console.WriteLine("People are dogs");
            }
            //the curly brackets are used to describe what the output will be from the if statement



        }
        static void Task2()
        {
            string dinosaur;
            Console.WriteLine("What famous dinosaur has the longest horns? ");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower() == "triceratops")
            {
                Console.WriteLine("You are correct!");
            }

            Console.WriteLine(dinosaur);

        }
        static void Task3()
        {
            string magicWord;
            Console.WriteLine("Whats the magic word? ");
            magicWord = Console.ReadLine();
            
            if (magicWord.ToLower() == "please")
            {
                Console.WriteLine("Youre welcome!");
            }
        }
        static void Task4()
        {
            int age;
            Console.Write("How old are you? ");
            Console.Write("");
            int.TryParse(Console.ReadLine(), out age);

        }
    }
}
