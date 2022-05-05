using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureAdd2 : MonoBehaviour
{
    private GameObject n_couch;
    private GameObject n_chair;
    private GameObject n_table;
    private GameObject n_bed;
    private GameObject n_desk;
    private GameObject n_office_chair;

    void Start() {
        n_couch = GameObject.Find("/Furniture/couch");
        n_chair = GameObject.Find("/Furniture/DinChair");
        n_table = GameObject.Find("/Furniture/DinTable");
        n_bed = GameObject.Find("/Furniture/Bed");
        n_desk = GameObject.Find("/Furniture/StudyTable");
        n_office_chair = GameObject.Find("/Furniture/Chair");
    }

    public void OnClickButton()
    {
        
        if(name=="couch"){
            Instantiate(n_couch,new Vector3(-5.8f,0.116262f,-27.5f),Quaternion.Euler(0.0f,0.0f,0.0f));

        }
        
        else if(name=="chair"){
            Instantiate(n_chair,new Vector3(-5.071313f,0.1f,-33.3f),Quaternion.Euler(0.0f,-90.0f,0.0f));

        }
        else if(name=="table"){
            Instantiate(n_table,new Vector3(-5.434752f,0.1f,-40.36f),Quaternion.Euler(0.0f, 90.0f, 0.0f));

        }

        else if(name=="bed"){
            Instantiate(n_bed,new Vector3(-14.73f,0.12f,-46.78794f),Quaternion.Euler(0.0f,180.0f,0.0f));

        }
        else if(name=="desk"){
            Instantiate(n_desk,new Vector3(-15.79084f,0.123f,-38.00f),Quaternion.Euler(0.0f,180.0f,0.0f));

        }
        else if(name=="off_chair"){
            Instantiate(n_office_chair,new Vector3(-14.78f,0.12f,-38f),Quaternion.Euler(0.0f,-90.0f,0.0f));

        }
    }
}