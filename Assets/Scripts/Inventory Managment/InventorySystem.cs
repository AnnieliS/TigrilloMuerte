using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem instance;
    public List<InventoryItemData> Items = new List<InventoryItemData>();

    #region inventory canvas objecta
    //only 7, not gonna do a complicated script. just gonna do it manually. too much to do besides this
    //just wanted to try and do a "proper" inventory. Realized I don't **really** need it halfway through.
    [SerializeField] GameObject knife;
    [SerializeField] GameObject crown;
    [SerializeField] GameObject beads;
    [SerializeField] GameObject cloth;
    [SerializeField] GameObject herbs;
    [SerializeField] GameObject statue;
    [SerializeField] GameObject pot;
    #endregion

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("Found more than one Inventory in the scene");
        }
        instance = this;

    }

    public static InventorySystem GetInstance()
    {
        return instance;
    }

    public void Add(InventoryItemData item)
    {
        Items.Add(item);
        ShowInCanvas(item.id);
    }

    private void ShowInCanvas(string item)
    {
        //should probably enum this :(
        //if I'll have the time at the end >.<
        switch (item)
        {
            case "Item_Beads":
                beads.SetActive(true);
                break;
            case "Item_Cloth":
                cloth.SetActive(true);
                break;
            case "Item_Crown":
                crown.SetActive(true);
                break;
            case "Item_Herbs":
                herbs.SetActive(true);
                break;
            case "Item_knife":
                knife.SetActive(true);
                break;
            case "Item_Pot":
                pot.SetActive(true);
                break;
            case "Item_Statue":
                statue.SetActive(true);
                break;
            default:
                break;
        }

    }


    //Removing items only at the end of the game, so kinda useless here.
    //Leaving here for future reference \ if needed eventually
    public void Remove(InventoryItemData item)
    {
        Items.Remove(item);
    }


}
