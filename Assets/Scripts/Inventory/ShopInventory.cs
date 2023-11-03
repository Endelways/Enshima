using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventory : Inventory<ShopInventorySlot>
{
    [SerializeField] List<ItemStack> basket = new List<ItemStack>();
    [SerializeField] private Text moneyBar;
    private static int moneys;
    [SerializeField] private int Moneys { get { return moneys; } set { moneys = value; moneyBar.text = $"Money: {moneys}"; } }
    public  void AddToBasket(ItemStack item, int money)
    {
        basket.Add(item);
        Moneys = money;

    }
}

