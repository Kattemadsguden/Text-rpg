//System instanciering
HpSystem Health = new HpSystem();
MoneySystem Money = new MoneySystem();
Shop TestShop = new Shop();

// Dialouge start

DialougeSystem NarratorDialouge1 = new DialougeSystem("Narrator", "You wake up cold and alone in a dark and moist basement. You can sense an evil energy in the room.");
DialougeSystem NarratorDialouge2 = new DialougeSystem("Narrator", "You look around and spot a door, and a window.");
DialougeSystem NarratorDialouge3 = new DialougeSystem("Narrator", "You go throug the door, and to your suprise there is a shop to your left");

// Dialouge end 

TestShop.UseAllItems();
PlayerChoice();




void PlayerChoice()
{
    NarratorDialouge1.displayDialouge();
    NarratorDialouge2.displayDialouge();

    Console.WriteLine("Press 1 to jump out of the window | Press 2 to go through the door");
    int spillervalg = int.Parse(Console.ReadLine());

    if (spillervalg == 1)
    {
        Health.HP += -5;
        Health.HpReader();
        

    }
    else if (spillervalg == 2)
    {
        NarratorDialouge3.displayDialouge();
    }
}



