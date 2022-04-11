using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtons : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.Two)){  //B: Go back
            character = GameObject.Find("/OurOVRPlayerController");
            CharacterController cc = character.GetComponent<CharacterController>();
            searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
            apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
            floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
            if(!searchMenu.active){
                if(!apartmentsMenu.active){
                    if(!floorPlanMenu.active){      //Nothing is open, go to floorplan
                        searchMenu.SetActive(false);
                        apartmentsMenu.SetActive(false);
                        floorPlanMenu.SetActive(true);
                        cc.enabled = false;
                        character.transform.position = new Vector3(32,2,0);
                        character.transform.rotation = Quaternion.Euler(0, -90, 0);
                        cc.enabled = true;
                    }  
                    else{   //Floorplan open, go to apartments
                        searchMenu.SetActive(false);
                        apartmentsMenu.SetActive(true);
                        floorPlanMenu.SetActive(false);
                    }
                }
                else {  //Apartments open, go to main menu (search)
                    searchMenu.SetActive(true);
                    apartmentsMenu.SetActive(false);
                    floorPlanMenu.SetActive(false);
                }
            } 
        }
        else if(OVRInput.GetDown(OVRInput.Button.One)){  //A: Go to home
            character = GameObject.Find("/OurOVRPlayerController");
            CharacterController cc = character.GetComponent<CharacterController>();
            searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
            apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
            floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
            if(!searchMenu.active && !apartmentsMenu.active && !floorPlanMenu.active){      //Teleport to Main room
                cc.enabled = false;
                character.transform.position = new Vector3(32,2,0);
                character.transform.rotation = Quaternion.Euler(0, -90, 0);
                cc.enabled = true;
            }
            searchMenu.SetActive(true);
            apartmentsMenu.SetActive(false);
            floorPlanMenu.SetActive(false);
        }
    }
}
