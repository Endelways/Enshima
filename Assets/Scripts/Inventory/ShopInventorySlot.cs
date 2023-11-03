using UnityEngine.EventSystems;

public class ShopInventorySlot : InventorySlot, IPointerClickHandler
{
    private int price;
    private ShopInventory inventory;
    public void Initialize(ItemStack item, int price)
    {
        inventory = transform.FindParent(parent => parent.name == "ShopInventory").GetComponent<ShopInventory>();
        base.Initialize(item);
        this.price = price;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.AddToBasket(Item, price);
    }
}

