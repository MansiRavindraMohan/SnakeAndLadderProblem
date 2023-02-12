namespace SnakeAndLadderProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.WriteLine("Number on the dice is: " + dice);
        }
    }
}