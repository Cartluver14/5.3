using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sky;
            int score = 0;
            int anwser2;
            string anwser3;
            string anwser4;

            Console.WriteLine("Hey today you will be taking a quiz, good luck");
            Console.WriteLine("Question 1 what colour is the sky?");
            sky = Console.ReadLine().ToLower();

            if (sky == "blue")
            {


                Console.WriteLine(" 1 for 1 good job");
                score += 1;
                

            }
            else
            {
                Console.WriteLine("Incorect");
            }
            Console.WriteLine();
            Console.WriteLine(" Your score is " + score);


            Console.WriteLine("Question 2 What year did covid 19 start?");

            int.TryParse(Console.ReadLine(), out anwser2);

            if (anwser2 == 2020)
            {

                Console.WriteLine("2 for 2 your doing great");
                score += 1;
            }
            else
            {
                Console.WriteLine("Incorect");
            }
            Console.WriteLine();
            Console.WriteLine(" Your score is " + score);

            Console.WriteLine("question 3 what is the capital of canada?");

            anwser3 = Console.ReadLine().ToLower();

            if (anwser3 == "ottawa")
            {


                Console.WriteLine("3 for 3 your doing great");
                score += 1;
            }
            else
            {
                Console.WriteLine("incorect");
            }
            Console.WriteLine();
            Console.WriteLine(" Your score is " + score);

            Console.WriteLine("question 4 what colour is the leaf on the canidain flag?         " +
                "A. blue " +
                "B. orange " +
                "C. red " +
                "D. white ");

            anwser4 = Console.ReadLine().ToLower();

            if (anwser4 == "red")
            {


                Console.WriteLine("4 for 4 your doing great");
                score += 1;
            }
            else
            {
                Console.WriteLine("wrong!!");
            }
            Console.WriteLine("The quiz is done good work thanks!");
            
            Console.WriteLine(" Your final score for the quiz is " + score);







        }
    }
}
