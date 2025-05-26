using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InventaryManager : MonoBehaviour
{
    public  static InventaryManager instance;

    public ScriptableItem[] weapons;
    public TextMeshProUGUI[] weaponsNames;
    public Image[] weaponScripts;

    

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
                weaponScripts[i].sprite = item.itemSprite;

               


                return;
            }
        }
    }
}
