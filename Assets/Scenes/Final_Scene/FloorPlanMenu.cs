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
            character.transform.position = new Vector3(3,2,25);
            character.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (name == "FPButton2")
        {
            character.transform.position = new Vector3(3,2,-30);
            character.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        floorPlanMenu.SetActive(false);
        searchMenu.SetActive(false);
        apartmentsMenu.SetActive(false);
    }

}
