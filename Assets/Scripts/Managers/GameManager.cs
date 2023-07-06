using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Ink.Runtime;

public class GameManager : MonoBehaviour
{
    #region inventory params
    [SerializeField] private GameObject knife;
    [SerializeField] private InventoryItemData statueData;

    [SerializeField] private AudioSource itemPickupSound;

    [Header("Items for endgame check")]
    [SerializeField] private InventoryItemData[] itemsForEndgame;
    #endregion

    #region cursor params
    [Header("Cursor")]
    [SerializeField] Texture2D cursorDef;
    [SerializeField] Texture2D cursorNPC;
    [SerializeField] Texture2D cursorItem;
    Vector2 hotspot;
    int cursorSpriteMode;
    CursorMode cursorMode = CursorMode.ForceSoftware;
    #endregion

    #region  canvas params
    [Header("Canvasai")]
    [SerializeField] GameObject inventory;
    [SerializeField] GameObject pauseCanvas;
    [SerializeField] GameObject mapCanvas;
    [SerializeField] GameObject templeCanvas;
    [SerializeField] GameObject finalCanvas;
    [SerializeField] GameObject quitCanvas;
    [SerializeField] GameObject openCutscene;
    #endregion

    #region World dialogue
    [Header("To Destroy")]
    [SerializeField] private GameObject templeCollider;
    #endregion

    #region  Events
    [Header("events")]
    // [SerializeField] private GameEvent stopPlayer;
    [SerializeField] private GameEvent startPlayer;
    [SerializeField] private GameEvent haltPlayer;
    [SerializeField] private GameEvent stopPlayer;

    #endregion
    private static GameManager instance;

    #region states params
    // should prob be a JSON with GE properly, but for so few not gonna do it.
    bool canPickCloth = false;
    bool canPickNecklace = false;
    bool canCollectWater = false;
    bool quitCanvasOpen = false;
    #endregion

    #region inits
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Game Manager in the scene");
        }
        instance = this;
    }
    private void Start()
    {
        CursorInit();
        templeCanvas.SetActive(false);
        finalCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    #endregion

    #region cutscenes

    public void EndOpenCutscene(Component sender, object data) { 
        openCutscene.SetActive(false);
        pauseCanvas.SetActive(true);
            }

    #endregion

    #region Cursor Functions
    void CursorInit()
    {
        Cursor.visible = false;
        float xspot = cursorDef.width / 2;
        float yspot = cursorDef.height / 2;
        hotspot = new Vector2(xspot, yspot);
        Cursor.SetCursor(cursorDef, hotspot, cursorMode);
    }

    public void ChangeCursor(Component sender, object data)
    {
        if ((string)data == "NPC")
            Cursor.SetCursor(cursorNPC, hotspot, cursorMode);

        if ((string)data == "Item")
            Cursor.SetCursor(cursorItem, hotspot, cursorMode);

        if ((string)data == "Def")
            Cursor.SetCursor(cursorDef, hotspot, cursorMode);
    }

    public void ResetCursor(Component sender, object data)
    {
        Cursor.SetCursor(cursorDef, hotspot, cursorMode);
    }
    #endregion

    #region inventory Functions
    //prevents the knife to be picked up before the cloth
    public void activateKnife()
    {
        knife.SetActive(true);
    }

    public void getStatue(GameObject statue)
    {
        InventorySystem.instance.Add(statueData);
        itemPickupSound.Play();
        templeCanvas.SetActive(false);
        startPlayer.Raise(this, "");
        Destroy(templeCollider);
    }


    #endregion



    #region canvaseus toggle

    public void TogglePause(Component sender, object data)
    {
        bool dataState = (bool)data;
        pauseCanvas.SetActive(dataState);
        Cursor.visible = !dataState;
        if (dataState) Time.timeScale = 0;
        if (!dataState) Time.timeScale = 1;
    }

    public void ToggleMap(Component sender, object data)
    {
        bool dataState = (bool)data;
        mapCanvas.SetActive(dataState);
    }

    public void ToggleInventory(Component sender, object data)
    {

        if ((bool)data)

            inventory.SetActive(false);

        if (!(bool)data)

            inventory.SetActive(true);


    }


    public void EnterTemple(Component sender, object data)
    {
        bool canEnter = (bool)data;
        if (canEnter)
        {
            stopPlayer.Raise(this, "");
            haltPlayer.Raise(this, "");
            templeCanvas.SetActive(true);
        }
    }

    public void ToggleQuitCanvas()
    {
        quitCanvasOpen = !quitCanvasOpen;
        quitCanvas.SetActive(quitCanvasOpen);
    }
    #endregion


    #region  endgame
    public void TempEndGame()
    {
        Debug.Log("enter function");
        bool canProceed = true;
        foreach (InventoryItemData item in itemsForEndgame)
        {
            Debug.Log(InventorySystem.GetInstance().Items);
            Debug.Log(InventorySystem.GetInstance().Items.Contains(item));
            canProceed = InventorySystem.GetInstance().Items.Contains(item);
            Debug.Log(canProceed);
            if (!canProceed) return;
        }

        finalCanvas.SetActive(true);

    }
    #endregion

    #region quit functions




    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion

}
