using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InventaryManagerWeapons : MonoBehaviour
{
    public  static InventaryManagerWeapons instance;

    public ScriptableItem[] weapons;
    public TextMeshProUGUI[] weaponsNames;
    public TextMeshProUGUI[] weaponsPrice;
    public Image[] weaponSprite;

    

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponSprite[i].sprite = item.itemSprite;
                weaponsPrice[i].text = item.itemPrice;

    
                return;
            }
        }
    }
}
