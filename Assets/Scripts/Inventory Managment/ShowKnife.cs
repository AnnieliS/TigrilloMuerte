using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKnife : MonoBehaviour
{
    [SerializeField] GameObject knife;
private void OnDestroy() {
    StartCoroutine(KnifeKnife());
}

 private IEnumerator KnifeKnife()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            knife.SetActive(true);
        }
    }
}
