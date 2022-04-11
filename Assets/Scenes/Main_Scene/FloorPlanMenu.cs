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
    }

    public void OnClickButton()
    {   
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        character = GameObject.Find("/OurOVRPlayerController");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
        if (name == "FPButton1")
        {
            CharacterController cc = character.GetComponent<CharacterController>();
            cc.enabled = false;
            character.transform.position = new Vector3(3,2,25);
            character.transform.rotation = Quaternion.Euler(0, -90, 0);
            cc.enabled = true;
        }
        else if (name == "FPButton2")
        {
            CharacterController cc = character.GetComponent<CharacterController>();
            cc.enabled = false;
            character.transform.position = new Vector3(3,2,-30);
            cc.enabled = true;
        }
        floorPlanMenu.SetActive(false);
        searchMenu.SetActive(false);
        apartmentsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
