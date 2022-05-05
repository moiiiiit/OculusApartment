using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    [SerializeField]
    public GameObject XROrigin;
    // Start is called before the first frame update
    void Start()
    {
        CharacterController cc = XROrigin.GetComponent<CharacterController>();
        cc.enabled = true;
        cc.attachedRigidbody.mass = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
