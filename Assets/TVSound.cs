using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[SerializeField]
AudioSource audio;

bool isPlaying;

public class TVSound : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
        else 
        {
             GetComponent<AudioSource>().Stop();
        }
    }


    public void OnPointerClick(PointerEventData pointerEventData)
    {
        isPlaying = !isPlaying;
    }
   
}
