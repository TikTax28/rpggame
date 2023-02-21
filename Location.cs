public class Location
{
    public int ID;
    public string Name;
    private string Description;
    private int? Item_id_to_have;
    private object? Obj1;
    private object? Obj2;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name, string description, int? item_id_to_have, object? obj1, object? obj2)
    {
        ID = id;
        Name = name;
        Description = description;
        Item_id_to_have = item_id_to_have;
        Obj1 = obj1;
        Obj2 = obj2;
    }

    public string Compass(string currentLocation)
    {
        string s = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }

    public Location GetLocationAt(string location)
    {
        if (location == "N") return LocationToNorth;
        if (location == "E") return LocationToEast;
        if (location == "S") return LocationToSouth;
        if (location == "W") return LocationToWest;
        return null;
    }
}

public class Player
{
    public Location CurrentLocation;
    private int? Item_id_to_have;
    public Player(Location currentLocation)
    {
        CurrentLocation = currentLocation;
    }

    public bool TryMoveTo(Location newLocation/*, int Item_id_to_have*/)
    {
        if (newLocation != null) //hieronder nog if statement om te checken voor adventurers pass.
        {
            if (CurrentLocation.Name == "Town square" && newLocation.Name == "Guard post" && Item_id_to_have == 7)
            {
                CurrentLocation = newLocation;
                return true;
            }
            else if (CurrentLocation.Name == "Town square" && newLocation.Name == "Guard post" && Item_id_to_have != 7)
            {
                Console.WriteLine("You can't go here yet, maybe you should go to the farmer's field");
                return false;
            }
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }
}