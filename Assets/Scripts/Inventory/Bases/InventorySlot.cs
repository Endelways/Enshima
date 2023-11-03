using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    // [SerializeField] private Text _id;

    // [SerializeField] private Text _description;
    //  [SerializeField] private Text _count;
    private ItemSlot itemSlot;
    protected ItemStack _item;

    //  public string Id => null;
    public ItemStack Item { get => _item; protected set => value.CopyTo(_item); }

    public void Initialize(ItemStack itemStack)
    {
        var slotInfo = transform.Find("Item").Find("Icon").GetComponent<Image>();
        var slotIcon = transform.Find("Item").Find("Info").GetComponent<Text>();
        itemSlot = new ItemSlot(slotInfo, slotIcon);
        _item = itemStack;
        Render(_item);

    }

    public void Render(ItemStack itemStack)
    {
        if (itemStack != null && itemStack.Item != null)
        {
            itemSlot.name.text = itemStack.DisplayName;                                                         
            itemSlot.icon.color = new Color(itemSlot.icon.color.r, itemSlot.icon.color.g, itemSlot.icon.color.b, 255);
            itemSlot.icon.sprite = itemStack.Item.Icon;
            itemStack.CopyTo(_item);
        }
        else
        {
            itemSlot.name.text = null;
            itemSlot.icon.color = new Color(itemSlot.icon.color.r, itemSlot.icon.color.g, itemSlot.icon.color.b, 0);
            itemSlot.icon.sprite = null;
            _item.EmptyStack();
        }

            //  _id.text = ItemStack.Item.Id.ToString();
            //   _description.text = ItemStack.DisplayDescription;
            //  _count.text = ItemStack.Count.ToString();
        
    }
    public void Render()
    {
        Render(_item);
    }

}

public struct ItemSlot
{
    public Text name;
    public Image icon;

    public ItemSlot(Image image, Text text) : this()
    {
        icon = image;
        name = text;
    }
}