using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;
using UnityEngine.UI;


public class UrlReciever : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Material[] materials;



    void Start()
    {
        print("PPRIORITY");
        print(SplitLink.VideoUrl);
        videoPlayer = GetComponent<VideoPlayer>();

        if (SplitLink.VideoColor == "ff0000")
        {
            GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (SplitLink.VideoColor == "0000ff")
        {
            GetComponent<MeshRenderer>().material = materials[1];
        }
        else if (SplitLink.VideoColor == "00ff00")
        {
            GetComponent<MeshRenderer>().material = materials[2];
        }
        Invoke(nameof(PlayVideo),0);
    }

    

    public void PlayVideo()
    {
        videoPlayer.url = SplitLink.VideoUrl;
        videoPlayer.Play();
    }


}
