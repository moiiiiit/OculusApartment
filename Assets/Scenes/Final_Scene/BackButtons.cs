using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BackButtons : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("/XR");
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
    }

    // Update is called once per frame
    void OnClickButton()
    {
        if (!searchMenu.active)
        {
            if (!apartmentsMenu.active)
            {
                if (!floorPlanMenu.active)
                {      //Nothing is open, go to floorplan
                    searchMenu.SetActive(false);
                    apartmentsMenu.SetActive(false);
                    floorPlanMenu.SetActive(true);
                    character.transform.position = new Vector3(32, 2, 0);
                    character.transform.rotation = Quaternion.Euler(0, -90, 0);
                }
                else
                {   //Floorplan open, go to apartments
                    searchMenu.SetActive(false);
                    apartmentsMenu.SetActive(true);
                    floorPlanMenu.SetActive(false);
                }
            }
            else
            {  //Apartments open, go to main menu (search)
                searchMenu.SetActive(true);
                apartmentsMenu.SetActive(false);
                floorPlanMenu.SetActive(false);
            }
        }
    }
}