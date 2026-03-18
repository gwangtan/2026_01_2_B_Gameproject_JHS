using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Inventory/ItemSO")]
public class ItemSO : ScriptableObject
{
    public int id;
    public string itemName;
    public string description;
    public string nameEng;
    public string itemTypeString;


    public ItemType itemType;
    public int price;
    public int power;
    public int level;
    public bool isStackable;
    public string iconPath;
    public Sprite icon;

    public override string ToString()
    {
        return $"[{id}] {itemName} ({itemType}) - 가격 : {price} 골드, 속성: {power}";
    }

    public string DisplayName
    {
        get { return string.IsNullOrEmpty(nameEng) ? itemName : nameEng; }

    }
}
