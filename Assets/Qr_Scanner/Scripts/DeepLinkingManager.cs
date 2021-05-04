using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeepLinkingManager : MonoBehaviour
{
    public static DeepLinkingManager Instance { get; private set; }
    public string deeplinkURL;

    public static string color;
    public static string videoId;
    public static string VideoUrl;

    //public Text message;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Application.deepLinkActivated += OnDeepLinkActivated;
            if (!String.IsNullOrEmpty(Application.absoluteURL))
            {
                // Cold start and Application.absoluteURL not null so process Deep Link.
                OnDeepLinkActivated(Application.absoluteURL);
            }
            // Initialize DeepLink Manager global variable.
            else deeplinkURL = "[none]";
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDeepLinkActivated(string url)
    {
        // Update DeepLink Manager global variable, so URL can be accessed from anywhere.
        deeplinkURL = url;

        // Decode the URL to determine action. 
        // In this example, the app expects a link formatted like this:
        // unitydl://com.Jekkna.app?AR_0000ff-7684233

        string[] split_urls = url.Split('?');

        string[] data = split_urls[1].Split('_');

        string sceneName = data[0];

        string[] videoData = data[1].Split('-');
        color = videoData[0];
        videoId = videoData[1];
        VideoUrl = ("https://dev.jekkna.com/wp-content/uploads/arvideos/" + videoId + ".mp4");


        bool validScene;
        switch (sceneName)
        {
            case "AR":
                validScene = true;
                break;
            default:
                validScene = false;
                break;
        }
        Debug.Log("Url From Web: " + deeplinkURL);

        //message.text = "From Web: " + VideoUrl + " Name: " + sceneName;
        if (validScene) SceneManager.LoadScene("DeepLinker");
    }
}