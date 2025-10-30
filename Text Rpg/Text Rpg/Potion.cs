public class Potion : Item
{
    
    public override void Use(HpSystem hpSystem)
    {
        Console.WriteLine("drinking potion");
        hpSystem.Hp += 10;
        
        
    }

}