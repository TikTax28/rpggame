using System.Collections.Generic;

public class Quest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public List<QuestItem> QuestCompletionItems { get; set; }
    public Item RewardItem { get; set; }

    public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
    {
        ID = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        QuestCompletionItems = new List<QuestItem>();
    }
}