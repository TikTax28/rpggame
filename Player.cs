public class Player
{
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int? Item_id_to_have;
    public int Level 
    {
        get { return ((ExperiencePoints / 100) + 1); }
    }
    public Location CurrentLocation { get; set; }
    public List<InventoryItem> Inventory { get; set; }
    public List<PlayerQuest> Quests { get; set; }

    public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints)
    {
        Gold = gold;
        ExperiencePoints = experiencePoints;

        Inventory = new List<InventoryItem>();
        Quests = new List<PlayerQuest>();
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