namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sky;
            int score = 0;
            string anwser2;
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
            Console.WriteLine();
            Console.WriteLine(" Your score is " + score);
            
         


        }
    }
}
