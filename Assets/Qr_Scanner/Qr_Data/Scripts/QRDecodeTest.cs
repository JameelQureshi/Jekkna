using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TBEasyWebCam;
using UnityEngine.Events;

public class QRDecodeTest : MonoBehaviour
{

	public QRCodeDecodeController e_qrController;
	
	public Text UiText;

	public GameObject resetBtn;

	public GameObject scanLineObj;
	#if (UNITY_ANDROID||UNITY_IOS) && !UNITY_EDITOR
	bool isTorchOn = false;
	#endif
	public Sprite torchOnSprite;
	public Sprite torchOffSprite;
	public Image torchImage;
	public static string text_to_pass;
	/// <summary>
	/// when you set the var is true,if the result of the decode is web url,it will open with browser.
	/// </summary>
	public bool isOpenBrowserIfUrl;

	public UnityEvent OnWrongQRScanned;
	public UnityEvent OnQRScanned;

	private void Start()
	{
		if (this.e_qrController != null)
		{
			this.e_qrController.onQRScanFinished += new QRCodeDecodeController.QRScanFinished(this.qrScanFinished);
		}

		Reset();
		if (this.e_qrController != null)
		{
			this.e_qrController.StartWork();
		}
	}

	private void Update()
	{
	}

	private void qrScanFinished(string dataText)
	{

		Debug.Log("Final Data:"+dataText);

		if (isOpenBrowserIfUrl) {
			if (Utility.CheckIsUrlFormat(dataText))
			{
				if (!dataText.Contains("http://") && !dataText.Contains("https://"))
				{
					dataText = "http://" + dataText;
				}
				Application.OpenURL(dataText);
			}
		}

		this.UiText.text = dataText;
		text_to_pass = dataText;

        if (text_to_pass.Contains("jekkna"))
        {
			SplitLink.Instance.AnalyseURL(text_to_pass);
			print(text_to_pass);
			OnQRScanned.Invoke();
        }
        else
        {
			OnWrongQRScanned.Invoke();
        }
		



		if (this.resetBtn != null)
		{
			this.resetBtn.SetActive(true);
		}
		if (this.scanLineObj != null)
		{
			this.scanLineObj.SetActive(false);
		}

	}

	public void Reset()
	{
		if (this.e_qrController != null)
		{
			this.e_qrController.Reset();
		}
		if (this.UiText != null)
		{
			this.UiText.text = string.Empty;
		}
		if (this.resetBtn != null)
		{
			this.resetBtn.SetActive(false);
		}
		if (this.scanLineObj != null)
		{
			this.scanLineObj.SetActive(true);
		}
	}

	//public void Play()
	//{
	//	Reset ();
	//	if (this.e_qrController != null)
	//	{
	//		this.e_qrController.StartWork();
	//	}
	//}

	public void Stop()
	{
		if (this.e_qrController != null)
		{
			this.e_qrController.StopWork();
		}

		if (this.resetBtn != null)
		{
			this.resetBtn.SetActive(false);
		}
		if (this.scanLineObj != null)
		{
			this.scanLineObj.SetActive(false);
		}
	}

	public void GotoNextScene(string scenename)
	{
		if (this.e_qrController != null)
		{
			this.e_qrController.StopWork();
		}
		
		SceneManager.LoadScene(scenename);
	}




}
