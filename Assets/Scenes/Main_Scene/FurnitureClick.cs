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
            
            // selectFurniture.transform.parent = parentCanvas.transform;
            // selectFurniture.transform.localPosition = new Vector3(0, 2, 0);  
            
    }

    // Update is called once per frame
    void Update()
    {
    }
}
