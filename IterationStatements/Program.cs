namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            int x = 9;
            int y = 10;

            int a = 11;
            int b = 12;
            

            Print1000();
            Print3Thru999();
            TwoParameters(x, y);
            EvenOrOdd(a);
            PositiveOrNegative(b);
            AgeOfVoter();
        }
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print3Thru999()
        {
            for (int i = 3; i >= 999; i += 3)
            {
                Console.WriteLine();
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TwoParameters(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static bool EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static string PositiveOrNegative(int b)
        {
            if (b >= 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static string AgeOfVoter(/*string age*/)
        {
            string age = Console.ReadLine();
            int parsedAge = Int32.Parse(age);

            if (parsedAge >= 18)
            {
                return "You can vote!";
            }
            else
            {
                return "You're too young, kid.";
            }
        }
    }
}