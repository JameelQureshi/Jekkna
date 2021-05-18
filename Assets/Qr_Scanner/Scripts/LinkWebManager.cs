using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkWebManager : MonoBehaviour
{
    public RectTransform refRect;
    private UniWebView webView;


    // Start is called before the first frame update
    void Start()
    {

        webView = gameObject.AddComponent<UniWebView>();
        webView.ReferenceRectTransform = refRect;

        // Load a URL.
        webView.Load("");
        webView.BackgroundColor = new Color(0, 0, 0, 0);

        webView.SetShowSpinnerWhileLoading(true);
        // Show it.
        webView.Show();


    }
}
