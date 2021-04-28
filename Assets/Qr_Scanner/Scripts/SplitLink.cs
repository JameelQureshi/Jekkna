using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SplitLink : MonoBehaviour
{
   // public string url;
   public static string VideoColor;
    string videoID;
    public static string VideoUrl;

   

    public UnityEvent OnVideoNotFound;
    public UnityEvent OnVideoFound;
    public static SplitLink Instance = null;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }

        Instance = this;
    }
    void Start()
    {
        // url = "https://dev.jekkna.com/product/sba014/#1894135";
        //url = "https://dev.jekkna.com/product/sba009-00ff00/#6544967";
    }



    public void AnalyseURL(string url)
    {
        if (url.Contains("-"))
        {
            Debug.Log("Video Found");
            string[] result = url.Split('-');

            string[] data = result[1].Split('/');

            VideoColor = data[0];
            
            videoID = data[1].Remove(0, 1);

            Debug.Log("Color is: " + VideoColor);
            //Debug.Log("VideoID is: " + videoID);
            
            VideoUrl = ("https://dev.jekkna.com/wp-content/uploads/arvideos/" + videoID + ".mp4");
            OnVideoFound.Invoke();
        }
        else
        {
            OnVideoNotFound.Invoke();
            Debug.Log("Video not found");
        }
    }

}

