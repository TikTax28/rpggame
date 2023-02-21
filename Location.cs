public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Item ItemRequiredToEnter { get; set; }
    public Quest QuestAvailableHere { get; set; }
    public Monster MonsterLivingHere { get; set; }
    public Vendor VendorWorkingHere { get; set; }
    public Location LocationToNorth { get; set; }
    public Location LocationToEast { get; set; }
    public Location LocationToSouth { get; set; }
    public Location LocationToWest { get; set; }

    public bool HasAQuest { get { return QuestAvailableHere != null; } }
    public bool DoesNotHaveAnItemRequiredToEnter { get { return ItemRequiredToEnter == null; } }

    public Location(int id, string name, string description, 
        Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
    {
        ID = id;
        Name = name;
        Description = description;
        ItemRequiredToEnter = itemRequiredToEnter;
        QuestAvailableHere = questAvailableHere;
        MonsterLivingHere = monsterLivingHere;
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
