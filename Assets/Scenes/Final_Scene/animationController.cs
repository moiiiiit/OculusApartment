using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    public voice vc_1;
     public voice vc_2;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        animator.SetBool("isTalking",false);
    }
    //animator.SetBool("isTalking",true);
    // Update is called once per frame
    void Update()
    {
        if(vc_1.voiceplay || vc_2.voiceplay)
        {
             animator.SetBool("isTalking",true);
        }
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Talking"))
        {
            vc_1.voiceplay=false;
            vc_2.voiceplay=false;
            animator.SetBool("isTalking",false);
        }

    }
}
