using System.Collections.Generic;
using UnityEngine;

/* ------------------------------------------
- INVENTORY
- The goal is to treat the inventory class like
  a container that just stores data. Facilitates
  modifications to it and that's all.
--------------------------------------------*/

public class Inventory
{  
    private List<InventoryItem> inventoryItems;

    public void AddItem(InventoryItem item)
    {
        for (int i = 0; i < this.inventoryItems.Count; i++)
        {
            if (!IsSlotEmpty(i)) continue;
            
        }
    }

    public void AddItem(InventoryItem item, int index)
    {
        
    }

    private bool IsSlotEmpty(int index)
    {
        return inventoryItems[index].IsEmpty();
    }
}

public class InventoryManager
{

}