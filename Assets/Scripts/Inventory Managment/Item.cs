using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public InventoryItemData item;
    [SerializeField] GameEvent onCursosOverItem;

    private void OnMouseEnter() {
        onCursosOverItem.Raise(this, "Item");
    }

    private void OnMouseExit() {
       onCursosOverItem.Raise(this, "Def");
    }
}
