public class LightBox : Box
{
    //properties & fields
    public int maximumWeight {get; private set;}
    private Item _item;
    
    //methods
    public override void Add(Item item) {
        _item = item;
    }

    public override bool IsInBox(Item item)
    {
        return _item.name.Equals(item.name);
    }
}
