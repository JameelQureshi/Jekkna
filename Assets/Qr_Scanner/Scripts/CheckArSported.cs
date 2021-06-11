using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
namespace ARSupportCheck
{ 
    public class CheckArSported : MonoBehaviour
    {
        public UnityEvent CheckArSport;

        public void Start()
        {
            if (!ARSupportChecker.IsSupported())
            {
                CheckArSport.Invoke();
            }
            
        }
    }
}
