using UnityEngine.EventSystems;

public class PlayerInventorySlot : InventorySlot, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (ItemDragger.SelectedItem.Item == null)
        {
            if (_item.Item != null)
            {
                ItemDragger.SelectedItem = _item;
                Render(null);
            }
        }
        else
        {
            if (_item.Item != null)
            {
                ItemStack newStack = new ItemStack();
                Item.CopyTo(newStack);
                Item = ItemDragger.SelectedItem;
                ItemDragger.SelectedItem = newStack;
                Render();
            }
            else
            {
                Render(ItemDragger.SelectedItem);
                ItemDragger.SelectedItem.EmptyStack();
            }
        }
    }
}

