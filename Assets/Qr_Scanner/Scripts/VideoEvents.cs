using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoEvents : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public UnityEvent onVideoStarted;
  
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.started += OnVideoStarted;
    }

   
    void OnVideoStarted(VideoPlayer vp)
    {
        Invoke(nameof(ActivateEvent), 10);
       
    }

    void ActivateEvent()
    {
        onVideoStarted.Invoke();
    }

}
