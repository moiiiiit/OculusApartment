using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HandRay : MonoBehaviour
{
    // LineRenderer
    private LineRenderer telekinesisLine;
    [SerializeField] private float lineMaxLength = 3f;
    [SerializeField] private float lineWidth = 0.01f;
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color pressedColor = Color.blue;
    // Toggle pointers on and off
    private bool toggledFlag = false;
    // Which trigger to get input from
    [Tooltip("Set to PrimaryIndexTrigger for left hand and SecondaryIndexTrigger for right hand")]
    [SerializeField] private OVRInput.Button triggerButton = OVRInput.Button.PrimaryIndexTrigger;
    // Reference to object raycast is hitting
    private GameObject currentTarget;
    // Reference to previousy hit object
    private GameObject previousTarget;
    Vector3 rayBase;
    Vector3 rayDirection;
    private void Awake()
    {
        // Get the LineRenderer component for displaying the ray
        telekinesisLine = GetComponent<LineRenderer>();
        rayBase = transform.position;
        rayDirection = transform.forward;
    }
    void Start()
    {
        // Start the LineRenderer at 0 to 0
        Vector3[] startLinePositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        telekinesisLine.SetPositions(startLinePositions);
        telekinesisLine.enabled = false;
        // Set how wide the LineRenderer appears
        telekinesisLine.startWidth = lineWidth;
        telekinesisLine.endWidth = lineWidth;

        telekinesisLine.startColor = normalColor;
        telekinesisLine.endColor = Color.clear;

        previousTarget = null;
        currentTarget = null;
    }

    void Update()
    {
        toggledFlag = true;

        if (OVRInput.GetDown(triggerButton))
        {
            telekinesisLine.startColor = pressedColor;
            //telekinesisLine.endColor = pressedColor;
        }
        else if (OVRInput.GetUp(triggerButton))
        {
            telekinesisLine.startColor = normalColor;
            //telekinesisLine.endColor = normalColor;
        }

        if (toggledFlag)
        {
            telekinesisLine.enabled = true;


           // Start raycast
            rayBase = Vector3.Lerp(rayBase, transform.position, 0.1f);
            rayDirection = Vector3.Lerp(rayDirection, transform.forward, 0.1f);
            currentTarget = telekinesis(rayBase, rayDirection, lineMaxLength);

            // If there's a current target, tell it that it's being targeted
            if (currentTarget != null)
            {
                // Trigger the object if button pressed down
                if (OVRInput.GetDown(triggerButton))
                {
                    currentTarget.SendMessage("Triggered");
                }

                currentTarget.SendMessage("Targeted");
            }

            // Check if targeted object changed
            if (previousTarget != currentTarget)
            {
                // Tell previous target it's no longer being targeted
                if (previousTarget != null)
                {
                    previousTarget.SendMessage("NotTargeted");
                }
            }

            previousTarget = currentTarget;
        }
        else
        {
            telekinesisLine.enabled = false;
            previousTarget = null;
            currentTarget = null;
        }
    }

    private GameObject telekinesis(Vector3 startPosition, Vector3 direction, float length)
    {
        GameObject hitObject;
        RaycastHit hit;
        Ray telekinesisOut = new Ray(startPosition, direction);

        // Endposition if nothing hit
       Vector3 endPosition = startPosition + (length * direction);

        // Set the raycast
        if (Physics.Raycast(telekinesisOut, out hit, length))       // Returns true if ray hits a collider
        {
            // Set the object that was hit
            hitObject = hit.collider.gameObject;

            // Update endPosition to where ray hit
            endPosition = hit.point;

            Debug.Log("Hit " + hitObject.name);
        }
        else
        {
            hitObject = null;
        }

        // Update the line renderer
        telekinesisLine.SetPosition(0, startPosition);
        telekinesisLine.SetPosition(1, endPosition);

        // Return object hit or null if nothing hit
        return hitObject;
    }

}