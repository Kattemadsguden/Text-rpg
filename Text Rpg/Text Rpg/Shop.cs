// dialouge

class Shop
{
    item[] ShopInventory = { new item(), new Potion() };





    public void UseAllItems()
    {
        //bruger alle shop items ved at cycle 
        for (int i = 0; i < ShopInventory.Length; i++)
        {
            ShopInventory[i].Use();
        }
    }
}

