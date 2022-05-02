using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManipulation : MonoBehaviour
{
    private double buttonDownTimer;
    private const double requiredDownTimer = 0.4;
    private bool buttonHeld = false;
    private GameObject character;
    private bool triggerFlag;
    private Rigidbody rb;
    Vector3 m_EulerAngleVelocity;
    Vector3 m_nEulerAngleVelocity;
    void Start()
    {
        character = GameObject.Find("/OurOVRPlayerController/OVRCameraRig/TrackingSpace/CenterEyeAnchor");
        rb = this.GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 45, 0);
        m_nEulerAngleVelocity = new Vector3(0, -45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerFlag)
        {
            if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
            {
                // Furniture clicked, held, and let go
                buttonHeld = false;
                buttonDownTimer = 0;
                transform.position = new Vector3(transform.position.x, 0.14f, transform.position.z);
                triggerFlag = false;
            }
            else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                // Furniture Clicked
            }
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                // Furniture Clicked and Held
                buttonDownTimer += Time.deltaTime;
                if (buttonDownTimer >= requiredDownTimer && !buttonHeld)
                {
                    buttonHeld = true;
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (buttonHeld && triggerFlag)
        {
            //Old
            //this.GetComponent<Rigidbody>().position = new Vector3(character.transform.position.x - 3f, 0.6f, character.transform.position.z - 1.5f) + (this.transform.forward * 3);

            rb.MovePosition(new Vector3(character.transform.position.x - 3f, 0.6f, character.transform.position.z - 1.5f) + (this.transform.forward * 3));

            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
            }
            else if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                Quaternion deltaRotation = Quaternion.Euler(m_nEulerAngleVelocity * Time.fixedDeltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
            }
        }
    }

    public void Triggered()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            triggerFlag = !triggerFlag;
        }
    }
}