using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beads : MonoBehaviour
{
    [SerializeField] GameEvent getBeads;
private void OnDestroy() {
    getBeads.Raise(this, "");
}
}
