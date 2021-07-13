using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InternetManager : MonoBehaviour
{
    public GameObject errorPopup;
   

    public void Start()
    {
        errorPopup.SetActive(false);
    }

    public void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            errorPopup.SetActive(true);
        }
        else
        {
            errorPopup.SetActive(false);
        }
        
      
    }

    public void quitGame()
    {
        print("Quit Game");
        Application.Quit();
        
    }

  

}
