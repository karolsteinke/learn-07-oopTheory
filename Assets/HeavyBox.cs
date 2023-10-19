public class HeavyBox : Box
{
    //properties & fields
    public int size {get; private set;}
    private Item[] _items;
    private int _counter = 0;

    //constructor
    public HeavyBox(int size) {
        this.size = size;
        _items = new Item[size];
    }

    //methods
    public override void Add(Item item)
    {
        if (_counter < _items.Length) {
            _items[_counter] = item;
            _counter++;
        }
    }

    public override bool IsInBox(Item item)
    {
        for (int i=0; i<_counter; i++) {
            if (_items[i].name.Equals(item.name)) {
                return true;
            }
        }
        return false;
    }
}
