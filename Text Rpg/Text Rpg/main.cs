
// Dialouge start

DialougeSystem NarratorDialouge1 = new DialougeSystem("Narrator", "You wake up cold and alone in a dark and moist basement. You can sense an evil energy in the room.");
DialougeSystem NarratorDialouge2 = new DialougeSystem("Narrator", "You look around and spot a door, and a window.");

// Dialouge end 


HpSystem Health = new HpSystem();

NarratorDialouge1.displayDialouge();
NarratorDialouge2.displayDialouge();

PlayerChoice();
void PlayerChoice()
{
    Console.WriteLine("Press 1 to jump out of the window | Press 2 to go through the door");
    int spillervalg = int.Parse(Console.ReadLine());

    if (spillervalg == 1)
    {
        Health.HP += -5;
        Console.WriteLine("you lost 5 hp | You now have " + Health.HP + " HP");

    }
    else if (spillervalg == 2) ;
}



