using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndQuitGame : MonoBehaviour
{
    private int IndexCopy;
    

    public void Update()
    {
        //secenController
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        IndexCopy = index;
    }

}
