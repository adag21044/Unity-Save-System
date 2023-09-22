using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}