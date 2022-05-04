using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentsMenu : MonoBehaviour
{
    private GameObject floorPlanMenu;
    private GameObject apartmentsMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
    }

    public void OnClickButton()
    {
        if (name == "Button")
        {
            apartmentsMenu.SetActive(false);
            floorPlanMenu.SetActive(true);
        }
    }
}
