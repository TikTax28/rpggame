// Code om te bewegen over de map.
Player player = new Player(World.Locations[0]);
string player_wants_to_move = "Y";
Console.WriteLine($"You are at: {player.CurrentLocation.Name}");

while (player_wants_to_move == "Y")
{
    Console.WriteLine(player.CurrentLocation.Compass(player.CurrentLocation.Name));
    string where_to_go = Console.ReadLine().ToUpper();
    int Item_id_to_have = 7;
    player.TryMoveTo(player.CurrentLocation.GetLocationAt(where_to_go)/*, Item_id_to_have*/);
    Console.WriteLine($"You are at: {player.CurrentLocation.Name}");
    Console.WriteLine("Move ? Y/N");
    player_wants_to_move = Console.ReadLine().ToUpper();
}


// Code om de map te bekijken.
Map map = new Map(player.CurrentLocation.Name);