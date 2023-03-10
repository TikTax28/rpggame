public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player(10, 10, 20, 0);
        player.Inventory.Add(new InventoryItem(World.ItemByID(World.WEAPON_ID_RUSTY_SWORD), 1));
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    
        while(true)
            {
                string player_wants_to_move = "Y";
                Console.WriteLine($"You are at: {player.CurrentLocation.Name}");

                while (player_wants_to_move == "Y")
                {
                    Console.WriteLine(player.CurrentLocation.Compass(player.CurrentLocation.Name));
                    string where_to_go = Console.ReadLine().ToUpper();
                    player.Item_id_to_have = 7;
                    player.TryMoveTo(player.CurrentLocation.GetLocationAt(where_to_go)/*, Item_id_to_have*/);
                    Console.WriteLine($"You are at: {player.CurrentLocation.Name}");
                    Console.WriteLine(player.CurrentLocation.Description);
                    Console.WriteLine("Move ? Y/N");
                    player_wants_to_move = Console.ReadLine().ToUpper();
                }


                // Code om de map te bekijken.
                Map map = new Map(player.CurrentLocation.Name);
            }
    }
}

