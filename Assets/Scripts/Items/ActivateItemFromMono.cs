using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
public class ActivateItemFromMono : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    [SerializeField] private string varToCheck;
    private bool canActivate;
    private bool activated = false;

    // Update is called once per frame
    void Update()
    {
        canActivate = ((Ink.Runtime.BoolValue) DialogueManager.GetInstance().GetVariableState(varToCheck)).value;
        if (canActivate && !activated){
            StartCoroutine(ActivateItem());
        }
    }

    private IEnumerator ActivateItem(){
        yield return new WaitForSeconds(1.5f);
        activated = true;
        toActivate.SetActive(true);
    }
}
