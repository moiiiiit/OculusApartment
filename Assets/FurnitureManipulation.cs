using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManipulation : MonoBehaviour
{
    //private bool triggerFlag;
    //public GameObject bed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0)
        {
            transform.Rotate(0, 45 * Time.deltaTime, 0);
        }
    }



    /*public void Triggered()
    {
        triggerFlag = !triggerFlag;

        if (triggerFlag)
            meshRenderer.material.color = triggeredColor;
    }*/
}
