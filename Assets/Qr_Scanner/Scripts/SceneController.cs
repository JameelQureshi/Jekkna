using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneController : MonoBehaviour
{
    public UnityEvent tap;

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void tapPanel()
    {
        if (Input.touchCount >0)
        {
            tap.Invoke();
        }
        
    }
   
    //public void OpenURL()
    //{
    //    Application.OpenURL(QRDecodeTest.text_to_pass);
    //}
}
