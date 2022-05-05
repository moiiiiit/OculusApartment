using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVSound : MonoBehaviour
{
    [SerializeField]
     GameObject audio;

    bool isPlay;

    // Start is called before the first frame update
    void Start()
    {
        isPlay = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            audio.GetComponent<AudioSource>().Play();
        }
        else
        {
            audio.GetComponent<AudioSource>().Stop();
        }
        
    }

    public void onPointerClick()
    {
        isPlay = !isPlay;
    }
}
