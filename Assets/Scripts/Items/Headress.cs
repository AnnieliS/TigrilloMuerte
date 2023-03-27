using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headress : MonoBehaviour
{

    [SerializeField] InventoryItemData item;
    bool canGetHeadress = false;
    bool gotHeadress = false;

    // Update is called once per frame
    void Update()
    {
        canGetHeadress = ((Ink.Runtime.BoolValue)DialogueManager.GetInstance().GetVariableState("gotHeadress")).value;
        if (canGetHeadress && !gotHeadress)
        {
            AddHeadToInventory();
        }
    }

    private void AddHeadToInventory()
    {
        InventorySystem.instance.Add(item);
    }
}
