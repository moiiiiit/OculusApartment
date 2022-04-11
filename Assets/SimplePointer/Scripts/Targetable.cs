using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetable : MonoBehaviour
{

    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color highlightedColor = Color.white;
    [SerializeField] private Color triggeredColor = Color.white;

    private MeshRenderer meshRenderer = null;
    private bool triggerFlag;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    #region Pointer Callbacks for HandRay script
    public void Targeted()
    {
        Debug.Log("The button is highlighted");
        if (!triggerFlag)
            meshRenderer.material.color = highlightedColor;
    }

    public void NotTargeted()
    {
        Debug.Log("The button is not highlighted");
        if (!triggerFlag)
            meshRenderer.material.color = normalColor;
    }

    public void Triggered()
    {
        triggerFlag = !triggerFlag;

        if (triggerFlag)
            meshRenderer.material.color = triggeredColor;
    }
    #endregion
}
