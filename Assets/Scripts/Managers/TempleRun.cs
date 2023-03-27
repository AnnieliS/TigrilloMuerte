using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleRun : MonoBehaviour
{
    [SerializeField] GameObject templeCanvas;
    [SerializeField] GameObject[] Floors;
    [SerializeField] GameEvent resumeRosa;
    private int floorCount = 0;
    bool Reachedtop = false;
    void Start()
    {
        if (!Reachedtop)
            ResetFloors();
    }

    public void rightFloor()
    {
        if (floorCount >= 0 && floorCount < 6)
        {
            Floors[floorCount].SetActive(false);
            floorCount++;
            Floors[floorCount].SetActive(true);
        }

        if (floorCount == 6) Reachedtop = true;
    }

    public void ResetFloors()
    {
        floorCount = 0;
        Floors[0].SetActive(true);
        Floors[1].SetActive(false);
        Floors[2].SetActive(false);
        Floors[3].SetActive(false);
        Floors[4].SetActive(false);
        Floors[5].SetActive(false);
    }

    public void ExitTemple()
    {
        ResetFloors();
        resumeRosa.Raise(this, "");
        templeCanvas.SetActive(false);
    }

}
