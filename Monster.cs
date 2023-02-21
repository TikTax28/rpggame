public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }


    public List<LootItem> LootTable { get; set; }

    internal List<InventoryItem> LootItems { get; }

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) 
        : base(currentHitPoints, maximumHitPoints)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;

        LootTable = new List<LootItem>();

        LootItems = new List<InventoryItem>();
    }
}
