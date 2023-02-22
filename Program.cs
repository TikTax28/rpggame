public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player(10, 10, 20, 0);
        player.Inventory.Add(new InventoryItem(World.ItemByID(World.WEAPON_ID_RUSTY_SWORD), 1));
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        string confirmation = "";
        int actionNumber;
        while(true)
        {
            // Check if player is 0 hp or below
            if (player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You are dead!");
                // Use readline to prevent instant exit
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (player.CurrentHitPoints > 0 && player.CurrentHitPoints < 5)
            {
                Console.WriteLine("Do you want to use hp pot? Y/N");
                string yes_no = Console.ReadLine().ToUpper();
                if (yes_no == "Y")
                {
                    player.CurrentHitPoints = player.MaximumHitPoints;
                }
            }
            // RPG Menu
            Console.WriteLine($"You are at: {player.CurrentLocation.Name}");
            Console.WriteLine("What would you like to do (Enter a number)?");
            Console.WriteLine("1: See game stats");
            Console.WriteLine("2: Move");
            Console.WriteLine("3: Map");
            Console.WriteLine("4: Fight");
            Console.WriteLine("5: Quit");
            actionNumber = Convert.ToInt32(Console.ReadLine());
            if (actionNumber == 1)
            {
                Console.WriteLine("--- Game Stats ---");
                Console.WriteLine($"MAX HP: {player.MaximumHitPoints}");
                Console.WriteLine($"Current HP: {player.CurrentHitPoints}");
                Console.WriteLine($"Gold: {player.Gold}");
                Console.WriteLine($"Experience Points: {player.ExperiencePoints}");
                Console.WriteLine("------------------");
            }
            else if (actionNumber == 2)
            {
                Console.WriteLine("Where would you like to go?");
                // Compass with the possible options
                Console.WriteLine(player.CurrentLocation.Compass(player.CurrentLocation.Name));
                player.Item_id_to_have = 7;
                string where_to_go = Console.ReadLine().ToUpper();
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(where_to_go)/*, Item_id_to_have*/);
            }
            else if (actionNumber == 3)
            {
                // Code om de map te bekijken.
                Console.WriteLine("--- Map ---");
                Map map = new Map(player.CurrentLocation.Name);
                Console.WriteLine("-----------");
            }
            else if (actionNumber == 4)
            {
                // id 5 = Alchemist garden
                if (player.CurrentLocation.ID == 5)
                {
                    // todo: implement fight
                }
                // id 7 = Farm field
                else if (player.CurrentLocation.ID == 7)
                {
                    // todo: implement fight
                }
                // id 9 = Spider field
                else if (player.CurrentLocation.ID == 9)
                {
                    // todo: implement fight
                }
                else
                {
                    Console.WriteLine($"--- Player cannot fight at {player.CurrentLocation.Name} ---");
                }
            }
            else if (actionNumber == 5)
            {
                Console.WriteLine("Are you sure you want to quit? Y/N");
                confirmation = Console.ReadLine().ToUpper();
                if (confirmation == "Y")
                {
                    Environment.Exit(0);
                }
                else
                {
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 5!");
            }
        }
    }
}

