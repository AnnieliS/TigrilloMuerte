using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingCutscene : MonoBehaviour
{
    [SerializeField] GameObject nextPart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("NextPart");
    }


    IEnumerator NextPart(){
        yield return new WaitForSeconds(7f);
            nextPart.SetActive(true);
            this.gameObject.SetActive(false);
    }
}
