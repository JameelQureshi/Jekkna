﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void OpenURL()
    {
        Application.OpenURL(QRDecodeTest.text_to_pass);
    }
}