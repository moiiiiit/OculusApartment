using System.Collections;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject backButton;

    void Start()
    {
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
        backButton = GameObject.Find("/Main UI Group/BackButtonCanvas/BackButton");
    }

    public void onButtonClick()
    {
        if (!searchMenu.active)
        {
            if (!apartmentsMenu.active)
            {
                if (!floorPlanMenu.active)
                {
                    //Nothing is open, go to floorplan
                    searchMenu.SetActive(false);
                    apartmentsMenu.SetActive(false);
                    floorPlanMenu.SetActive(true);
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
                backButton.SetActive(false);
                searchMenu.SetActive(true);
                apartmentsMenu.SetActive(false);
                floorPlanMenu.SetActive(false);
            }
        }
    }
}
