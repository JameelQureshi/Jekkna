using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkWebManager : MonoBehaviour
{
    public RectTransform refRect;
    private UniWebView webView;
    private string urlreasiever;


    // Start is called before the first frame update
    public void OpenLink()
    {

        webView = gameObject.AddComponent<UniWebView>();
        webView.ReferenceRectTransform = refRect;

        // Load a URL.
        urlreasiever=QRDecodeTest.text_to_pass;
        webView.Load(urlreasiever);
        webView.BackgroundColor = new Color(0, 0, 0, 0);

        webView.SetShowSpinnerWhileLoading(true);
        // Show it.
        webView.Show();


    }
}
