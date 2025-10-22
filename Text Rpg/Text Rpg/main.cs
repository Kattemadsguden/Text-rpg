//System instanciering
HpSystem Health = new HpSystem();
PlayerInventorySystem testinventory = new PlayerInventorySystem();
Shop TestShop = new Shop();

// Dialouge start

DialougeSystem NarratorDialouge1 = new DialougeSystem("Narrator", "You wake up cold and alone in a dark and moist basement. You can sense an evil energy in the room.");
DialougeSystem NarratorDialouge2 = new DialougeSystem("Narrator", "You look around and spot a door, and a window.");
DialougeSystem NarratorDialouge3 = new DialougeSystem("Narrator", "You go throug the door, and to your suprise there is a shop to your left");
DialougeSystem NarratorDialouge4 = new DialougeSystem("Narrator", "You hit the ground hard and the world starts to blacken, when you wake up again you spot a shop clos by");
DialougeSystem NarratorDialouge5 = new DialougeSystem("Narrator", "You decide to stop by the shop and see if the shop keeper is selling something useful");
DialougeSystem ShopKeeperDialouge1 = new DialougeSystem("Shop Keeper", "Hello my freind do you want to buy some items?");

// Dialouge end 
//TestShop.BuyItems();
//TestShop.UseAllItems();
//TestShop.UseItemInInventory();



PlayerChoice();




void PlayerChoice()
{
    while (true)
    {
        NarratorDialouge1.displayDialouge();
        NarratorDialouge2.displayDialouge();

        Console.WriteLine("Press 1 to jump out of the window | Press 2 to go through the door");
        int spillervalg = int.Parse(Console.ReadLine());

        if (spillervalg == 1)
        {

            NarratorDialouge4.displayDialouge();
            Health.HP += -5;
            Health.HpReader();


        }
        else if (spillervalg == 2)
        {
            NarratorDialouge3.displayDialouge();
            NarratorDialouge5.displayDialouge();
        }

    }
   


}



