// dialouge

class Shop
{
    public MoneySystem money = new MoneySystem();
    public PlayerInventorySystem PlayerInventory = new PlayerInventorySystem();
    HpSystem MainHp = new HpSystem();

   
    Item[] ShopInventory = { new Item(), new Potion() };
    
    public void BuyItems()
    {
        while (true)
        {
            Console.WriteLine("You have " + money.Gold + " Gold");
            Console.WriteLine(ShopInventory[0] + " | " + ShopInventory[1]);
            Console.WriteLine("press 1 to buy " + ShopInventory[0] + " | " + "press 2 to buy " + ShopInventory[1]);
            Console.WriteLine("press 0 to quit shop menu");
            int shopSpillervalg = int.Parse(Console.ReadLine());
            if (shopSpillervalg == 1 && money.Gold >= 500)
            {
                PlayerInventory.Inventory[0] = ShopInventory[0];

            }
            else if (shopSpillervalg == 2 && money.Gold >= 37)
            {
                
                
                CheckInventorySpace();
                if (PlayerInventory.Inventory[0] == null)
                {
                    PlayerInventory.Inventory[0] = ShopInventory[1];
                    Console.WriteLine(PlayerInventory.Inventory[0]);
                    money.Gold -= 37;
                }
                else if (PlayerInventory.Inventory[1] == null)
                {
                    PlayerInventory.Inventory[1] = ShopInventory[1];
                    Console.WriteLine(PlayerInventory.Inventory[1]);
                    money.Gold -= 37;

                }
                else if (PlayerInventory.Inventory[2] == null)
                {
                    PlayerInventory.Inventory[2] = ShopInventory[1];
                    Console.WriteLine(PlayerInventory.Inventory[2]);
                    money.Gold -= 37;
                }
                else if (PlayerInventory.Inventory[3] == null)
                {
                    PlayerInventory.Inventory[3] = ShopInventory[1];
                    Console.WriteLine(PlayerInventory.Inventory[3]);
                    money.Gold -= 37;
                }

                
            }
            else if (shopSpillervalg == 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("you are broke and couldn't afford the item");
                
            }
        }
    }

    public void UseAllItems()
    {
        //bruger alle shop items ved at cycle 
        for (int i = 0; i < ShopInventory.Length; i++)
        {
            ShopInventory[i].Use();
        }
    }

    public void UseItemInInventory()
    {

        Console.Clear();
        Console.WriteLine("---USE AN ITEM---");
        Console.WriteLine("Press 1 to use " + PlayerInventory.Inventory[0] + " |" + " Press 2 to use " + PlayerInventory.Inventory[1] + " |" + " Press 3 to use " + PlayerInventory.Inventory[2] + " |" + " Press 4 to use " + PlayerInventory.Inventory[3]);
        Console.WriteLine("To quit this menu press 0");
        int InventoryItemChoice = int.Parse(Console.ReadLine());
        if (InventoryItemChoice == 1)
        {

            PlayerInventory.Inventory[0].Use(MainHp);
        }
        else if (InventoryItemChoice == 2)
        {
            PlayerInventory.Inventory[1].Use(MainHp);
        }
        else if (InventoryItemChoice == 3)
        {
            PlayerInventory.Inventory[2].Use(MainHp);
        }
        else if (InventoryItemChoice == 4)
        {
            PlayerInventory.Inventory[3].Use(MainHp);
        }
        else if (InventoryItemChoice == 0)
        {

        }

    }

    public void InventoryActivate()
    {
        Console.WriteLine("Press i to open inventory");
        string InventoryACTIVATEkey = Console.ReadLine();
        if (InventoryACTIVATEkey == "i")
        {
            UseItemInInventory();
        }
    }

    public void CheckInventorySpace()
    {
        for (int i = 0; i < PlayerInventory.Inventory.Length; i++)
        {
            if (PlayerInventory.Inventory[i] == null)
            {
                continue ;
            }
            else if (PlayerInventory.Inventory[0] != null && PlayerInventory.Inventory[1] != null && PlayerInventory.Inventory[2] != null && PlayerInventory.Inventory[3] != null)
            {
                Console.WriteLine("You dont have any space in your inventory");
                BuyItems();
                                                                                                                                                                                                                                                                                                }

        }
       
        
    }

    public void HpReader()
    {
        Console.WriteLine("You have " + MainHp.Hp + " HP");
    }

    public void TakeDamage()
    {
        MainHp.Hp -= 10;
        Console.WriteLine("You lost 10 HP");
        HpReader();
    }

}

class PlayerInventorySystem
{

    public Item[] Inventory = new Item[4];


}
