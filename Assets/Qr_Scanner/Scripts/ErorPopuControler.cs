using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Errorpopup;
    private void Update()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            Errorpopup.SetActive(false);
        }
        else

        {
            Errorpopup.SetActive(true);
        }
    }
    
}
