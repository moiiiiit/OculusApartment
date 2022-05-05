using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch01 : MonoBehaviour
{
    [SerializeField]
    GameObject myLight;

    //Detect if a click occurs
    public void OnPointerClick()
    {
        myLight.GetComponent<Light>().enabled = !myLight.GetComponent<Light>().enabled; 
    }
}
