using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightSwitch01 : MonoBehaviour, IPointerClickHandler
{
    GameObject myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GameObject.FindWithTag( "PointLight1");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        myLight.GetComponent<Light>().enabled = !myLight.GetComponent<Light>().enabled; 
    }
}
