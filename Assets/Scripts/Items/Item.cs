using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item :  ScriptableObject, IItem
{

    public int Id => _id;

    public string Name => _name;

    public string Description => _description;

    public Sprite Icon => _icon;

    public Transform Model => _model;

    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _model;
}

