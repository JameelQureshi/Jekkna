using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneController : MonoBehaviour
{
    private int IndexCopy;
    
    public void Update()
    {     
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(IndexCopy);
            } 
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        IndexCopy=index;
        print("Scan Qr");
    }
  
   
    
}
