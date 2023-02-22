public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Item ItemRequiredToEnter { get; set; }
    public Quest QuestAvailableHere { get; set; }
    public Monster MonsterLivingHere { get; set; }
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

