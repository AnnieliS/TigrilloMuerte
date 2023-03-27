using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : MonoBehaviour
{

    [SerializeField] private GameEvent pickup;
    
    private void OnDestroy() {
        pickup.Raise(this, "");
    }
}
