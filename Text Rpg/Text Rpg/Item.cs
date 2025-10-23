public class Item
{
    
    public virtual void Use()
    {
        Console.WriteLine("generic use");
    }

    public virtual void Use(HpSystem hpSystem)
    {

    }
}