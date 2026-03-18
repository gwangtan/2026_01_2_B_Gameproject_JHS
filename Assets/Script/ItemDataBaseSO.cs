using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ItemDataBaseSO", menuName = "Inventory/DataBase")]
public class ItemDataBaseSO : ScriptableObject
{
    public List<ItemSO>items = new List<ItemSO>();

    private Dictionary<int, ItemSO> itemsByld;
    private Dictionary<string, ItemSO> itemsByName;

    public void Initialze()
    {
        itemsByld = new Dictionary<int, ItemSO>();
        itemsByName = new Dictionary<string, ItemSO>();

        foreach (var item in items)
        {
            itemsByld[item.id] = item;
            itemsByName[item.itemName] = item;
        }
    }


    public ItemSO GetItemByld(int id)
    {
        if(itemsByld == null)
        {
            Initialze();
        }

        if(itemsByld.TryGetValue(id, out ItemSO item))
            return item;

        return null; 

    }

    public ItemSO GetItemByName(string name)
    {
        if(itemsByName == null)
        {
            Initialze();
        }

        if (itemsByName.TryGetValue(name, out ItemSO item))
            return item;
        return null;
    }

    public List<ItemSO> GetItemByType(ItemType type)
    {
        return items.FindAll(item => item.itemType == type);
    }
}
