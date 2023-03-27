using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class NPC : MonoBehaviour
{
    [Header("Eventes")]
    [SerializeField] GameEvent onCursosOnNPC;

    private void OnMouseEnter() {
        onCursosOnNPC.Raise(this, "NPC");
    }

    private void OnMouseExit() {
        onCursosOnNPC.Raise(this, "Def");
    }
}
