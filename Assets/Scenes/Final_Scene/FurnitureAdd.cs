using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureAdd : MonoBehaviour
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
            Instantiate(n_couch,new Vector3(-7.15f,0.116262f,24.57f),Quaternion.Euler(0.0f,0.0f,0.0f));

        }
        
        else if(name=="chair"){
            Instantiate(n_chair,new Vector3(-6.23f,0.1f,31f),Quaternion.Euler(0.0f,-90.0f,0.0f));

        }
        else if(name=="table"){
            Instantiate(n_table,new Vector3(-6.87f,0.1f,29.14f),Quaternion.Euler(0.0f, 90.0f, 0.0f));

        }

        else if(name=="bed"){
            Instantiate(n_bed,new Vector3(-6.3245f,0.12f,14.21349f),Quaternion.Euler(0.0f,180.0f,0.0f));

        }
        else if(name=="desk"){
            Instantiate(n_desk,new Vector3(0.504f,0.123f,13.51f),Quaternion.Euler(0.0f,180.0f,0.0f));

        }
        else if(name=="off_chair"){
            Instantiate(n_office_chair,new Vector3(-0.377f,0.12f,13.88249f),Quaternion.Euler(0.0f,-90.0f,0.0f));

        }
    }
}