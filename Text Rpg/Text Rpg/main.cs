//System instanciering
HpSystem PlayerHpSystem = new HpSystem();
PlayerInventorySystem Inventory = new PlayerInventorySystem();
Shop MainShop = new Shop();
Potion testpotion = new Potion();
// Dialouge start
DialougeSystem systemdialouge1 = new DialougeSystem("System", "Press enter to start the experience");
DialougeSystem systemdialouge2 = new DialougeSystem("System", "Press enter to continoue");


DialougeSystem NarratorDialouge1 = new DialougeSystem("Narrator", "You wake up cold and alone in a dark and moist basement. You can sense an evil energy in the room.");
DialougeSystem NarratorDialouge2 = new DialougeSystem("Narrator", "You look around and spot a door, and a window.");
DialougeSystem NarratorDialouge3 = new DialougeSystem("Narrator", "You go throug the door, and to your suprise there is a shop to your left");
DialougeSystem NarratorDialouge4 = new DialougeSystem("Narrator", "You hit the ground hard and the world starts to blacken, when you wake up again you spot a shop close by");
DialougeSystem NarratorDialouge5 = new DialougeSystem("Narrator", "You decide to stop by the shop and see if the shop keeper is selling something useful");

DialougeSystem ShopKeeperDialouge1 = new DialougeSystem("Shop Keeper", "Hello my freind do you want to buy some items?");

// Dialouge end 

//Continue function 

void Continue()
{
    systemdialouge2.displayDialouge();
    Console.ReadLine();
    Console.Clear();
}




systemdialouge1.displayDialouge();
Console.ReadLine();

Console.Clear();
Rungame();




void Rungame()
{
    
        NarratorDialouge1.displayDialouge();
        NarratorDialouge2.displayDialouge();

        Console.WriteLine("Press 1 to jump out of the window | Press 2 to go through the door");
        int spillervalg = int.Parse(Console.ReadLine());

        if (spillervalg == 1)
        {
            Console.Clear();

            NarratorDialouge4.displayDialouge();
            PlayerHpSystem.TakeDamage(); 

            Continue(); 
            

        }
        else if (spillervalg == 2)
        {
            NarratorDialouge3.displayDialouge();
            

            Continue();
        }

    NarratorDialouge5.displayDialouge();
    Continue();

    ShopKeeperDialouge1.displayDialouge();
    MainShop.BuyItems();




}



