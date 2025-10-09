// dialouge

class Shop
{
   public MoneySystem money = new MoneySystem();

    

    item[] ShopInventory = { new item(), new Potion() };
    item[] PlayerInventory = new item[4];
    public void BuyItems()
    {
        Console.WriteLine(ShopInventory[0] + " | " +ShopInventory[1]);
        Console.WriteLine("press 1 to buy " + ShopInventory[0] + " | " + "press 2 to buy " + ShopInventory[1] );
        int shopSpillervalg = int.Parse(Console.ReadLine());
        if (shopSpillervalg == 1 && money.Gold >= 500 )
        {
            PlayerInventory[0] = ShopInventory[0];
            Console.WriteLine(PlayerInventory[0]);
        }
        else if (shopSpillervalg == 2 && money.Gold >= 37)
        {
            PlayerInventory[0] = ShopInventory[1];
            Console.WriteLine(PlayerInventory[0]);
            
        }
        else
        {
            Console.WriteLine("you are broke and couldn't afford the item");
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
}


