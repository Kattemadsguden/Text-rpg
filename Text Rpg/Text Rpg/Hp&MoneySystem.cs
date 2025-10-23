public class HpSystem
{
    public int HP = 50;


    public void HpReader()
    {
        Console.WriteLine("You have " + HP + " HP");
    }
   
    public void TakeDamage()
    {
        HP -= 10;
        Console.WriteLine("You lost 10 HP");
        HpReader();
    }
   
   
}
public class MoneySystem
{

    public int Gold = 50;

    public void GoldReader()
    {
        Console.WriteLine("You have " + Gold + " gold");
    }

}
