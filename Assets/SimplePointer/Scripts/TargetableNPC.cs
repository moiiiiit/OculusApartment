using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetableNPC : MonoBehaviour
{
    private Outline outline = null;
    private bool triggerFlag;
    private Color normalColor;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
        normalColor = outline.OutlineColor;
    }

    #region Pointer Callbacks for HandRay script
    public void Targeted()
    {
        Debug.Log("The NPC is highlighted");
        if (!triggerFlag)
        {
            outline.enabled = true;
        }
    }

    public void NotTargeted()
    {
        Debug.Log("The NPC is not highlighted");
        if (!triggerFlag)
        {
            outline.enabled = false;
        }
    }

    public void Triggered()
    {
        triggerFlag = !triggerFlag;

        if (triggerFlag)
        {
            outline.OutlineColor = Color.red;
        }
        else
        {
            outline.OutlineColor = normalColor;
        }
    }
    #endregion
}
