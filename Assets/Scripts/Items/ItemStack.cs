using System;
using UnityEngine;

[Serializable]
public class ItemStack : IItemStack
{
    public Item Item => _item;
    public int Count => _count;
    public string DisplayName => _displayName;
    public string DisplayDescription => _displayDescription;

    public ItemStack()
    {
        EmptyStack();
    }


    public void CopyTo(ItemStack newField)
    {
        if (newField == null)
            newField = new ItemStack();
        newField._item = _item;
        newField._count = _count;
        newField._displayName = _displayName;
        newField._displayDescription = _displayDescription;
    }

    public void EmptyStack()
    {
        _item = null;
        _count = 0;
        _displayName = null;
        _displayDescription = null;
    }

    static public void Swap(ItemStack item1, ItemStack item2)
    {
        ItemStack newStack = new ItemStack();
        item1.CopyTo(newStack);
        item2.CopyTo(item1);
        newStack.CopyTo(item2);
    }

    [SerializeField] private Item _item;
    [SerializeField] private int _count;
    [SerializeField] private string _displayName;
    [SerializeField] private string _displayDescription;

}
