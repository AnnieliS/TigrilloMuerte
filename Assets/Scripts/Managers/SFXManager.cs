using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [Header("Intervals")]
    [SerializeField] float soundLength;
    [SerializeField] float maxInterval;
    private AudioSource audioSource;
    private float currentInterval;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentInterval = Random.Range(soundLength, maxInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentInterval > Mathf.Epsilon){
            StartCoroutine(PlaySound(currentInterval));
        }
    }

    private IEnumerator PlaySound(float waitTime){
        currentInterval = 0f;
        yield return new WaitForSeconds(waitTime);
        audioSource.Play();
        currentInterval = Random.Range(soundLength, maxInterval);   
    }
}
