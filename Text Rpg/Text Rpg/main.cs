

DialougeSystem NewDialouge = new DialougeSystem("Narrator", "You wake up cold and alone");
HpSystem Health = new HpSystem();

PlayerChoice();
void PlayerChoice()
{
    Console.WriteLine("Tast 1 eller 2");
    int spillervalg = int.Parse(Console.ReadLine());
    
    if (spillervalg == 1)
    {
        Health.HP += -5;
        Console.WriteLine("you lost 5 hp");
        Health.HpReader();
    }

}


