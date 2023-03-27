using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerActions : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] GameEvent onDoubleClick;
    [SerializeField] GameEvent toggleInventory;
    [SerializeField] GameEvent startDialogue;
    [SerializeField] GameEvent continueDialogue;

    [SerializeField] GameEvent stopDialogue;
    [SerializeField] GameEvent enterTemple;
    [SerializeField] GameEvent pause;
    [SerializeField] GameEvent map;
    [SerializeField] GameEvent table;
    [SerializeField] GameEvent quit;
    bool invantoryOpen = false;
    bool canPressContinue = true;
    bool isPaused = true;
    bool isMapOpen = false;
    bool canEnterTemple;
    string clickTag = "";

    private GameObject tempGameObj;

    private void Start()
    {
        // open screen for now
        pause.Raise(this, isPaused);
    }

    private void Update()
    {
        canEnterTemple = ((Ink.Runtime.BoolValue)DialogueManager.GetInstance().GetVariableState("canTemple")).value;
    }

    void OnCollect()
    {
        if (clickTag != "")
            onDoubleClick.Raise(tempGameObj.GetComponent<ItemPickup>(), clickTag);
        startDialogue.Raise(this, clickTag);

        if (clickTag == "temple")
        {
            enterTemple.Raise(this, canEnterTemple);
        }
        if (clickTag == "table")
        {
            table.Raise(this, "");
        }
    }

    void OnDiaContinue()
    {
        if (clickTag != "" && canPressContinue)
        {
            canPressContinue = false;
            continueDialogue.Raise(this, clickTag);
            StartCoroutine(ResetPress());
        }

    }

    void OnOpenInventory()
    {
        toggleInventory.Raise(this, invantoryOpen);
        invantoryOpen = !invantoryOpen;
    }

    void OnPause()
    {
        isPaused = !isPaused;
        pause.Raise(this, isPaused);
    }

    void OnMap()
    {
        map.Raise(this, isMapOpen);
        isMapOpen = !isMapOpen;
    }

    void OnStopDia()
    {
        stopDialogue.Raise(this, "");
    }

    void OnExitGame()
    {
        quit.Raise(this,"");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        clickTag = other.tag;
        tempGameObj = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        clickTag = "";
    }

    private IEnumerator ResetPress()
    {
        yield return new WaitForSeconds(0.5f);
        canPressContinue = true;
    }

}
