//System instanciering
HpSystem PlayerHpSystem = new HpSystem();
PlayerInventorySystem Inventory = new PlayerInventorySystem();
Shop MainShop = new Shop();
Potion testpotion = new Potion();
// Dialouge start
DialougeSystem systemdialouge1 = new DialougeSystem("System", "Press enter to start the experience");
DialougeSystem systemdialouge2 = new DialougeSystem("System", "Press enter to continoue");
DialougeSystem systemdialouge3 = new DialougeSystem("System", "YOU DIE | GAME OVER");
DialougeSystem systemdialouge4 = new DialougeSystem("System", "YOU WIN :) ");


DialougeSystem NarratorDialouge1 = new DialougeSystem("Narrator", "You wake up cold and alone in a dark and moist basement. You can sense an evil energy in the room.");
DialougeSystem NarratorDialouge2 = new DialougeSystem("Narrator", "You look around and spot a door, and a window.");
DialougeSystem NarratorDialouge3 = new DialougeSystem("Narrator", "You go throug the door, and to your suprise there is a shop to your left");
DialougeSystem NarratorDialouge4 = new DialougeSystem("Narrator", "You hit the ground hard and the world starts to blacken, when you wake up again you spot a shop close by");
DialougeSystem NarratorDialouge5 = new DialougeSystem("Narrator", "You decide to stop by the shop and see if the shop keeper is selling something useful");
DialougeSystem NarratorDialouge6 = new DialougeSystem("Narrator", "You hear a deep roumbling coming from the tower that you just left, you sense an evil wizardly presence");
DialougeSystem NarratorDialouge7 = new DialougeSystem("Narrator", "The wizard prepares another fireball, What will you do?");
DialougeSystem NarratorDialouge8 = new DialougeSystem("Narrator", "The wizard prepares his final attack, if you dodge this attack you will win");
DialougeSystem NarratorDialouge9 = new DialougeSystem("Narrator", "You dodged the fireball and to your suprise the wizard dies from the sheer pressure of missing his ultimate fireball");
DialougeSystem NarratorDialouge10 = new DialougeSystem("Narrator", "You decide to just accept your fate as the fireball engulfs you.");

DialougeSystem NarratorDialougeHIT = new DialougeSystem("Narrator", "You block the fireball with your fists but to your suprise your fists aren't fireproof, and you take damage");
DialougeSystem NarratorDialougeHIT2 = new DialougeSystem("Narrator", "You get hit by the fireball and take damage");
DialougeSystem NarratorDialougeDODGE = new DialougeSystem("Narrator", "You dodge the fireball just as its coming towards you, and you therefor take no damage");
DialougeSystem NarratorDialougeDODGE2 = new DialougeSystem("Narrator", "You dodge and take no damage");


DialougeSystem ShopKeeperDialouge1 = new DialougeSystem("Shop Keeper", "Hello my freind do you want to buy some items?");

DialougeSystem EvilWizardDialouge1 = new DialougeSystem("Evil Wizard", "Who do you think you are? Did you really think that you could escape my EEEEVIL tower without having a harrowingly EEVIL encounty with me?");
DialougeSystem EvilWizardDialouge2 = new DialougeSystem("Evil Wizard", "Prepare to die scum, because i cast EVIIL FIREBALL");

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
 // Intro   
        NarratorDialouge1.displayDialouge();
        NarratorDialouge2.displayDialouge();

        Console.WriteLine("Press 1 to jump out of the window | Press 2 to go through the door");
        int PlayerChoice = int.Parse(Console.ReadLine());

        if (PlayerChoice == 1)
        {
            Console.Clear();

            NarratorDialouge4.displayDialouge();
            MainShop.TakeDamage(); 

            Continue(); 
            

        }
        else if (PlayerChoice == 2)
        {
            NarratorDialouge3.displayDialouge();
            

            Continue();
        }
 // Shop encounter
    NarratorDialouge5.displayDialouge();
    Continue();

    ShopKeeperDialouge1.displayDialouge();
    MainShop.BuyItems();

    MainShop.UseItemInInventory();

    MainShop.HpReader();
    Continue();
    // Evil wizard encounter 

    NarratorDialouge6.displayDialouge();
    Continue();

    EvilWizardDialouge1.displayDialouge();
    Continue();

    EvilWizardDialouge2.displayDialouge();
    Continue();

    //First fireball
    Console.WriteLine("Press 1 to block the fireball with your fists | Press 2 to dodge the fireball");
    int PlayerChoice2 = int.Parse(Console.ReadLine());
    
    if (PlayerChoice2 == 1)
    {
        NarratorDialougeHIT.displayDialouge();
        MainShop.TakeDamage();
    }
    else if (PlayerChoice2 == 2)
    {
        NarratorDialougeDODGE.displayDialouge();
    }
    Continue();
    //Inventory Use 1
    Console.WriteLine("Do you want to use inventory?");
    Console.WriteLine("Press 1 to use inventory | Press 2 to continue");
    int playerchoiceINV = int.Parse(Console.ReadLine());

    if (playerchoiceINV == 1)
    {
        MainShop.UseItemInInventory();
    }
    else if (playerchoiceINV == 2)
    {
        
    }
    
    // Second fireball
    NarratorDialouge7.displayDialouge();

    Console.WriteLine("Press 1 to get hit by the fireball | Press 2 to dodge the fireball");
    int PlayerChoice3 = int.Parse(Console.ReadLine());

    if (PlayerChoice3 == 1)
    {
        NarratorDialougeHIT2.displayDialouge();
        MainShop.TakeDamage();
    }
    else if (PlayerChoice3 == 2)
    {
        NarratorDialougeDODGE2.displayDialouge();
    }
    Continue();
    // Inventory use 2
    Console.WriteLine("Do you want to use inventory?");
    Console.WriteLine("Press 1 to use inventory | Press 2 to continue");
    int playerchoiceINV2 = int.Parse(Console.ReadLine());

    if (playerchoiceINV2 == 1)
    {
        MainShop.UseItemInInventory();
    }
    else if (playerchoiceINV == 2)
    {

    }
   
    //Third fireball
    NarratorDialouge8.displayDialouge();

    Console.WriteLine("Press 1 to get hit by the final fireball | Press 2 to dodge the final fireball");
    int PlayerChoice4 = int.Parse(Console.ReadLine());

    if (PlayerChoice4 == 1)
    {
        NarratorDialouge10.displayDialouge();
        
    }
    else if (PlayerChoice4 == 2)
    {
        NarratorDialouge9.displayDialouge();
    }
    Continue();

    if(PlayerChoice4 == 1)
    {
        systemdialouge3.displayDialouge();
    }
    else if (PlayerChoice4 == 2)
    {
        systemdialouge4.displayDialouge();
    }



}



