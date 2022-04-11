using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    private bool triggerFlag;
    private bool defaultPosition;

    [SerializeField]
    public GameObject interactableObject; // Game object to apply interactions to 
    public int rotationDegrees; // This is the integer move value which will be set by menu and used by scripts
    public string axis; // x, y, z axis which will decide what transform is used

    private void Awake()
    {
        defaultPosition = true;
    }

    public void Triggered()
    {
        triggerFlag = !triggerFlag;

        //Interactions that will reset to default position
        if (triggerFlag && defaultPosition)
        {
            defaultPosition = false;

            if (axis.Equals("x"))
            {
                interactableObject.transform.Rotate(new Vector3(rotationDegrees, 0, 0));
            }
            else if (axis.Equals("y"))
            {
                interactableObject.transform.Rotate(new Vector3(0, rotationDegrees, 0));
            }
            else if (axis.Equals("z"))
            {
                interactableObject.transform.Rotate(new Vector3(0, 0, rotationDegrees));
            }
            else if (axis.Equals("window"))
            {
                interactableObject.transform.Translate(new Vector3(0, 1.0f, 0));
            }

        }
        else if (triggerFlag && !defaultPosition) //Interactions that will modify position
        {
            defaultPosition = true;
            if (axis.Equals("x"))
            {
                interactableObject.transform.Rotate(new Vector3(-rotationDegrees, 0, 0));
            }
            else if (axis.Equals("y"))
            {
                interactableObject.transform.Rotate(new Vector3(0, -rotationDegrees, 0));
            }
            else if (axis.Equals("z"))
            {
                interactableObject.transform.Rotate(new Vector3(0, 0, -rotationDegrees));
            }
            else if (axis.Equals("window"))
            {
                interactableObject.transform.Translate(new Vector3(0, -1.0f, 0));
            }
        }
    }
}