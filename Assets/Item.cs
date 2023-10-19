public class Item
{
    public string name {get; private set;}
    public int weight {get; private set;}

    public Item(string name, int weight) {
        this.name = name;
        this.weight = weight;
    }
}
