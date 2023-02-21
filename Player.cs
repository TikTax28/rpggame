public class Player : LivingCreature
{
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level 
    {
        get { return ((ExperiencePoints / 100) + 1); }
    }
    public Location CurrentLocation { get; set; }
    public List<InventoryItem> Inventory { get; set; }
    public List<PlayerQuest> Quests { get; set; }

    private Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints) : base(currentHitPoints, maximumHitPoints)
    {
        Gold = gold;
        ExperiencePoints = experiencePoints;

        Inventory = new List<InventoryItem>();
        Quests = new List<PlayerQuest>();
    }
    
    public static Player CreateDefaultPlayer()
    {
        Player player = new Player(10, 10, 20, 0);
        player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        return player;
    }
}
