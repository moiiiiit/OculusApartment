using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureAdd : MonoBehaviour
{
    private GameObject couch;
    private GameObject chair;
    private GameObject table;
    private GameObject bed;
    private GameObject desk;
    private GameObject office_chair;

    public void OnClickButton()
    {
        
        if(name=="couch"){
            couch = Instantiate(Resources.Load("couch", typeof(GameObject))) as GameObject;
            couch.transform.position = new Vector3(-7.15f,0.116262f,24.57f);
            couch.transform.Rotate(0.0f,0.0f,0.0f);
        }
        
        else if(name=="chair"){
            chair= Instantiate(Resources.Load("DinChair", typeof(GameObject))) as GameObject;
            chair.transform.position = new Vector3(-6.23f,0.1f,31f);
            chair.transform.Rotate(0.0f,-90.0f,0.0f);
        }
        else if(name=="table"){
            table = Instantiate(Resources.Load("DinTable", typeof(GameObject))) as GameObject;
            table.transform.localPosition = new Vector3(-6.87f,0.1f,29.14f);
            table.transform.Rotate(0.0f, 90.0f, 0.0f);
        }

        else if(name=="bed"){
            bed= Instantiate(Resources.Load("Bed", typeof(GameObject))) as GameObject;
            bed.transform.position = new Vector3(-6.3245f,0.12f,14.21349f);
            bed.transform.Rotate(0.0f,180.0f,0.0f);
        }
        else if(name=="desk"){
            desk= Instantiate(Resources.Load("StudyTable", typeof(GameObject))) as GameObject;
            desk.transform.position = new Vector3(0.504f,0.123f,13.51f);
            bed.transform.Rotate(0.0f,180.0f,0.0f);
        }
        else if(name=="off_chair"){
            office_chair= Instantiate(Resources.Load("Chair", typeof(GameObject))) as GameObject;
            office_chair.transform.position = new Vector3(-0.377f,0.12f,13.88249f);
            office_chair.transform.Rotate(0.0f,-90.0f,0.0f);
        }
    }
}