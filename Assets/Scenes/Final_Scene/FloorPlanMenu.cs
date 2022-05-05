using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPlanMenu : MonoBehaviour
{
    private GameObject floorPlanMenu;
    private GameObject apartmentsMenu;
    private GameObject searchMenu;
    private GameObject character;


    // Start is called before the first frame update
    void Start()
    {
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        character = GameObject.Find("/XR");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
    }

    public void OnClickButton()
    {   
        if (name == "FPButton1")
        {
            character.transform.position = new Vector3(1.5f+3.22f,1.5f,25-2.75f);
            character.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (name == "FPButton2")
        {
            character.transform.position = new Vector3(3,1.5f,-30);
        }
        floorPlanMenu.SetActive(false);
        searchMenu.SetActive(false);
        apartmentsMenu.SetActive(false);
    }

}
