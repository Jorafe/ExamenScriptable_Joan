using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWeapon : MonoBehaviour
{
    public ScriptableItem itemInfo;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = itemInfo.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventaryManagerWeapons.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
