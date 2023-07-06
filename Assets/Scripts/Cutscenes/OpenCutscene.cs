using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OpenCutscene : MonoBehaviour
{

    [SerializeField] GameEvent openSceneDone;
    VideoPlayer videoPlayer;
    bool envoked = false;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;
    }

    private void EndReached(VideoPlayer source)
    {
        Debug.Log("Finish Cutscene");
        envoked = true;
        openSceneDone.Raise(this, "");
    }

}
