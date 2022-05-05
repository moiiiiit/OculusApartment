using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    public AudioSource NPCvoice;
    public bool voiceplay;
    public AudioSource Greet;
    public AudioSource bed1;
    public FloorPlanMenu pl;

    
    // Start is called before the first frame update
    void Start()
    {
        voiceplay=false;
        Greet.PlayDelayed(1);
    }
    void Update()
    {
        if(pl.plan1)
        {
            voiceplay=true;
            bed1.Play();
            pl.plan1=false;
        }
    }
    public void OnClickButton()
    { 
        NPCvoice.Play();
        voiceplay=true;
    }
    // public void talkingAnimation()
    // {
    //     animator.SetBool("isTalking",true);
    // }
}
