namespace SnakeAndLadderProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int startPosition = 0;
            int[] Ladder = { 4,16, 38, 70, 94 };
            int[] Snake = { 19, 32, 63, 85 };

            int endPosition = 100;

            int player;
            int total=0;
            int i;

            for (i= 0; i<=30; i++) 
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine("Number on the dice is: " + dice);
                
                total =total+dice;

                var check = Array.Exists(Ladder, x => x == total);
                var check1 = Array.Exists(Snake, x => x == total);
                if (check == true)
                {
                    total = total + dice;
                    Console.WriteLine("Great!! you got a ladder !! You are at position", +total);
                }
                else if (check1 == true)
                {
                    total = total - dice;
                    Console.WriteLine("Oops!! Snake found !! You are at postion", +total);
                }
                else if (total >= 100)
                {
                    Console.WriteLine("You won the game");
                }
                else
                {
                    total = total;
                }
                
            }
           

        }
    }
}