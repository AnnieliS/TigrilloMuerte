using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItemData item;
    [SerializeField] GameEvent pickupItem;
    Collider2D mycollider;

    private void Awake()
    {
        mycollider = GetComponent<Collider2D>();
    }


    public void Pickup(Component sender, object data)
    {
        Debug.Log(sender);
        if(sender){
        InventoryItemData senderItem = sender.gameObject.GetComponent<ItemPickup>().item;
        if (senderItem == item)
        {
            InventorySystem.instance.Add(item);
            StartCoroutine(DestroyItem());
        }}
    }

    private IEnumerator DestroyItem()
    {
        yield return new WaitForSeconds(0.5f);
        pickupItem.Raise(this, "");
        yield return new WaitForEndOfFrame();
        Destroy(gameObject);
    }


}
