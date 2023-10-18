public class Item
{
    private string _name;
    private int _weight;

    public Item(string name, int weight) {
        this._name = name;
        this._weight = weight;
    }
    
    public int GetWeight() {
        return _weight;
    }
}
