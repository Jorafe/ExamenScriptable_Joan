using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]

public class ScriptableItem : ScriptableObject
{
    public string itemName;
    public string itemPrice;
    public Sprite itemSprite;
}
