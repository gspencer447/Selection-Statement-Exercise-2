namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "science":
                    Console.WriteLine("Your favorite subject is Science!");
                    break;

                case "social studies":
                    Console.WriteLine("Your favorite subject is Social Studies!");
                    break;

                case "math":
                    Console.WriteLine("Your favorite subject is Math!");
                    break;

                case "writing":
                    Console.WriteLine("Your favorite subject is Writing!");
                    break;

                case "reading":
                    Console.WriteLine("Your favorite subject is Reading!");
                    break;

                default:
                    Console.WriteLine("Invalid subject.");
                    break;
            }
        }
    }
}