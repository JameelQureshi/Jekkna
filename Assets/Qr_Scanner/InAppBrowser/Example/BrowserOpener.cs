using UnityEngine;
using System.Collections;

public class BrowserOpener : MonoBehaviour {

	public string pageToOpen = "https://www.google.com";

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		//options.pageTitle = "InAppBrowser example";

		InAppBrowser.OpenURL(QRDecodeTest.text_to_pass);
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}
