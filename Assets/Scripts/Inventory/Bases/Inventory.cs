using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<SlotType> : MonoBehaviour where SlotType : InventorySlot
{
    [SerializeField] private List<ItemStack> items = new List<ItemStack>();
    [SerializeField] private SlotType slotPrototype;
    [SerializeField] private Containers containers;

    public void Start()
    {
        Render(items);
    }

    private void Render(List<ItemStack> items)
    {
        foreach (Transform child in containers.InventoryContainer)                                                                                                                              
            Destroy(child.gameObject);

        items.Add(new ItemStack());

        for (int i = 0; i < items.Count; i++)
        {
            var cell = Instantiate(slotPrototype, containers.InventoryContainer);
            cell.Initialize(items[i]);
        }

        //var acell = Instantiate(_inventoryCellPrototype, _inventoryContainer);
        //acell.Initialize(new ItemStack(), SlotType.InventorySlot);
    }

    internal void RemoveItem(ItemStack item)
    {
       items.Remove(item);
    }
}

[Serializable]
public struct Containers
{
    public Transform InventoryContainer;
}