using UnityEngine;

// SHIT NAME
public class InventoryContainer : ScriptableObject
{
    public Sprite itemSprite;
}

public class Organ : InventoryContainer 
{
    public int freshness;
}

public class InventoryItem
{
    InventoryContainer item;
    int count = 0;

    public bool IsEmpty() { return count == 0; }
}
