using UnityEngine;

public interface IItemStack
{
    public Item Item { get; }
    public int Count { get; }
    public string DisplayName { get; }
    public string DisplayDescription { get; }
}

