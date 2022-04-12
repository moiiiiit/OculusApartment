using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManipulation : MonoBehaviour
{ 
    private bool triggerFlag;
    //public GameObject bed;
    // Start is called before the first frame update

    //GameObject reticleEnd = GameObject.Find("/UIHelpers/Sphere");
    void Start()
    {
        triggerFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerFlag)
        {
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0)
            {
                this.transform.Rotate(0, 45 * Time.deltaTime, 0);
            }
            else if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0)
            {
                this.transform.Rotate(0, -45 * Time.deltaTime, 0);
            }
            else if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0)
            {
                GameObject character = GameObject.Find("/OurOVRPlayerController/OVRCameraRig/TrackingSpace/TrackerAnchor");
                this.transform.position = character.transform.position + (this.transform.forward * 3) - this.transform.up - new Vector3(3,0.1f,1.5f);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
                triggerFlag = false;
            }
        }

    }

    public void Triggered()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0)
        {
            triggerFlag = !triggerFlag;
        }

    }
}