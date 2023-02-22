public class PlayerQuest
{
    private Quest _details;
    private bool _isCompleted;

    public Quest Details
    {
        get { return _details; }
        set
        {
            _details = value;
        }
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
        set
        {
            _isCompleted = value;
        }
    }

    public string Name
    {
        get { return Details.Name; }
    }

    public PlayerQuest(Quest details)
    {
        Details = details;
        IsCompleted = false;
    }
}

