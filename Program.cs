public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player(10, 10, 20, 0);
        Item hp_pot = new Item(1, "HP Pot", "Item for healing");
        Item rusty_sword = new Item(2, "Rusty Sword", "Beginners Sword");
        player.Inventory.Add(new InventoryItem(World.ItemByID(World.WEAPON_ID_RUSTY_SWORD), 1));
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        InventoryItem starter_sword = new InventoryItem(rusty_sword, 1);
        string confirmation = "";
        while(true)
            {
                string player_wants_to_move = "Y";
                Console.WriteLine($"You are at: {player.CurrentLocation.Name}");

                while (player_wants_to_move == "Y")
                {
                    if (player.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("You are dead!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine(player.CurrentLocation.Compass(player.CurrentLocation.Name));
                    string where_to_go = Console.ReadLine().ToUpper();
                    if (where_to_go == "Q" || where_to_go == "QUIT" || where_to_go == "EXIT")
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
                    player.Item_id_to_have = 7;
                    player.TryMoveTo(player.CurrentLocation.GetLocationAt(where_to_go)/*, Item_id_to_have*/);
                    Console.WriteLine($"You are at: {player.CurrentLocation.Name}");
                    Console.WriteLine(player.CurrentLocation.Description);
                    Console.WriteLine("Move ? Y/N");
                    player_wants_to_move = Console.ReadLine().ToUpper();
                    if (player_wants_to_move == "Q" || player_wants_to_move == "QUIT" || player_wants_to_move == "EXIT")
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
                }


                // Code om de map te bekijken.
                Map map = new Map(player.CurrentLocation.Name);
            }
    }
}

