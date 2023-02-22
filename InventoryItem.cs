public class InventoryItem
{
    private Item _details;
    private int _quantity;

    public Item Details
    {
        get { return _details; }
        set
        {
            _details = value; 
        }
    }

    public int Quantity
    {
        get { return _quantity; }
        set
        {
            _quantity = value; 
        }
    }

    public int ItemID
    {
        get { return Details.ID; }
    }

    public string Description
    {
        get { return Quantity > 1 ? Details.NamePlural : Details.Name; }
    }

    public InventoryItem(Item details, int quantity)
    {
        Details = details;
        Quantity = quantity;
    }
}

