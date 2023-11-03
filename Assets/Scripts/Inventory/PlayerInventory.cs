using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : Inventory<PlayerInventorySlot>
{
    [SerializeField] private Text moneyBar;
    private int moneys;
    [SerializeField] private int Moneys { get { return moneys; } set { moneys = value; moneyBar.text = $"Money: {moneys}"; } }
    public void Update()
    {
        if (ItemDragger.SelectedItem.Item != null)
        {
            if (!ItemDragger.getActive())
                ItemDragger.SetActive(true);
        }
        else
        {
            if (ItemDragger.getActive())
                ItemDragger.SetActive(false);
        }
    }
}

