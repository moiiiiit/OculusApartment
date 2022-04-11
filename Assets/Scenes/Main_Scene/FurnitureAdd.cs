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

    void Start()
    {

    }

    public void OnClickButton()
    {
        
        if(name=="couch"){
            couch = Instantiate(Resources.Load("couch", typeof(GameObject))) as GameObject;
            couch.transform.position = new Vector3(-7.0287f,0.21635f,24.32f);
            couch.transform.Rotate(0.0f,0.0f,0.0f);
            couch.transform.localScale = new Vector3(1.3359f,1.3359f,1.3359f);
        }
        
        else if(name=="chair"){
            chair= Instantiate(Resources.Load("DinChair", typeof(GameObject))) as GameObject;
            chair.transform.position = new Vector3(-6.947f,0.08f,20.358f);
            chair.transform.Rotate(0.0f,-90.0f,0.0f);
            chair.transform.localScale = new Vector3(0.001966334f,0.001966334f,0.001966334f);
        }
        else if(name=="table"){
            table = Instantiate(Resources.Load("DinTable", typeof(GameObject))) as GameObject;
            table.transform.localPosition = new Vector3(-4.02f,0.14262f,31.06f);
            //table.transform.position = new Vector3(-3, 0, 25);
            table.transform.Rotate(0.0f, 90.0f, 0.0f);
            table.transform.localScale = new Vector3(1.228957f, 1.228957f, 1.228957f);
        }

         else if(name=="bed"){
            bed= Instantiate(Resources.Load("Bed", typeof(GameObject))) as GameObject;
            bed.transform.position = new Vector3(-5.29f,0.073209f,14.193f);
            bed.transform.Rotate(0.0f,-180.0f,0.0f);
            bed.transform.localScale = new Vector3(0.01740134f,0.01740134f,0.01740134f);
        }
        else if(name=="desk"){
            desk= Instantiate(Resources.Load("StudyTable", typeof(GameObject))) as GameObject;
            desk.transform.position = new Vector3(-0.42f,-0.228f,12.93f);
            desk.transform.Rotate(0.0f,-90.0f,0.0f);
            desk.transform.localScale = new Vector3(0.3037427f,0.3037427f,0.3037427f);
        }
        else if(name=="off_chair"){
            office_chair= Instantiate(Resources.Load("Chair", typeof(GameObject))) as GameObject;
             office_chair.transform.position = new Vector3(0.72613f,0.294f,14.905f);
             office_chair.transform.Rotate(0.0f,-90.0f,0.0f);
             office_chair.transform.localScale = new Vector3(0.01748f,0.01748f,0.01748f);
        }
    // Update is called once per frame
    void Update()
    {

    }
}
}
