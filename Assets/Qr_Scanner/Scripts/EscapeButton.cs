using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeButton : MonoBehaviour
{
    public GameObject instructionPanel;
    private int IndexCopy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            {

                if (instructionPanel.activeInHierarchy)
                {
                    instructionPanel.SetActive(false);
                }
                else
                {
                    SceneManager.LoadScene(IndexCopy);
                }

            }
        
    }

    public void LoadScene(int index)
    {

        SceneManager.LoadScene(index);
        IndexCopy = index;
    }


}
