using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureClick: MonoBehaviour
{
    public GameObject selectFurniture;
    
    // Start is called before the first frame update
    void Start()
    {
        selectFurniture.gameObject.SetActive(false);
    }

    public void OnClickButton()
    { 
        selectFurniture.gameObject.SetActive(true);  
    }
}
