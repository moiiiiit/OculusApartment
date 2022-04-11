using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineEnabler : MonoBehaviour
{

    private bool triggerFlag;
    Outline outline;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    #region Pointer Callbacks for OutlineEnabler script
    public void Targeted()
    {
        Debug.Log("The object is outlined");
        if (!triggerFlag)
            outline.enabled = true;
    }

    public void NotTargeted()
    {
        Debug.Log("The object is not outlined");
        if (!triggerFlag)
            outline.enabled = false;
    }
    #endregion
}