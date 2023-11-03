using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class ItemDragger : MonoBehaviour
{
    [ShowInInspector] public static ItemStack SelectedItem 
    { 
        get 
        { 
            return selectedItem; 
        }
        set 
        { 
            Debug.Log($"set {value.DisplayName}"); 
            slot.icon.sprite = value.Item.Icon; 
            slot.name.text = value.DisplayName; 
            value.CopyTo(selectedItem); 
        }
    }

    private static ItemStack selectedItem = new ItemStack();
    private static GameObject itemDragger;
    [ShowInInspector] static ItemSlot slot; 
    private void Start()
    {
        itemDragger = gameObject;
        slot = new ItemSlot(transform.Find("Icon").GetComponent<Image>(), transform.Find("Info").GetComponent<Text>());                                                                 
        gameObject.SetActive(false);
    }

    private void Update()
    {
        itemDragger.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
    public static void SetActive(bool isActive)
    {
       itemDragger.SetActive(isActive);
    }

    public static bool getActive()
    {
        return itemDragger.activeSelf;
    }
}