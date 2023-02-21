public class Program
{
    private static Player _player;

    private static void main(string[] args)
    {
         while(true)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();

                if(userInput == null)
                {
                    continue;
                }
                string cleanedInput = userInput.ToLower();

                if(cleanedInput == "exit")
                {

                    break;
                }

                ParseInput(cleanedInput);
            }
    }
}
