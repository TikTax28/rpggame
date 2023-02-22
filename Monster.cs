public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }


    public List<Item> Loot { get; set; }

    internal List<InventoryItem> LootItems { get; }

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) 
        
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;

        Loot = new List<Item>();

        LootItems = new List<InventoryItem>();
    }
}
