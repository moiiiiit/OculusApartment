using System.Collections;
using UnityEngine;

public class PrimaryReactor : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject character;

    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        character = GameObject.Find("/XR");
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
    }

    public void onPrimaryButtonEvent(bool pressed)
    {
        if (IsPressed != pressed)
        {
            IsPressed = pressed;
            if (pressed)
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
                            character.transform.position = new Vector3(32, 1.5f, 0);
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

                else if (OVRInput.GetDown(OVRInput.Button.One))
                {  //A: Go to home
                    if (!searchMenu.active && !apartmentsMenu.active && !floorPlanMenu.active)
                    {      //Teleport to Main room
                        character.transform.position = new Vector3(32, 1.5f, 0);
                        character.transform.rotation = Quaternion.Euler(0, -90, 0);
                    }
                    searchMenu.SetActive(true);
                    apartmentsMenu.SetActive(false);
                    floorPlanMenu.SetActive(false);
                }
            }
        }
    }
}