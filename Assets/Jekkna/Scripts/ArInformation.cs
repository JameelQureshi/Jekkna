using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArInformation : MonoBehaviour
{

    public GameObject Arinstruction;
   

    public void ArInfoCross()
    {
        Arinstruction.SetActive(false);

        print("Cross working");
    }
    public void ArInfoClick()
    {
        Arinstruction.SetActive(true);
    }

    


}
