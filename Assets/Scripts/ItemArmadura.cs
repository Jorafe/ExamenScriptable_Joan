using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArmadura : MonoBehaviour
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
        InventaryManagerArmadura.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
