using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPlanMenu : MonoBehaviour
{
    private GameObject floorPlanMenu;
    private GameObject apartmentsMenu;
    private GameObject searchMenu;
    private GameObject character;
<<<<<<< Updated upstream
    private CharacterController cc;
=======
    public bool plan1;
>>>>>>> Stashed changes


    // Start is called before the first frame update
    void Start()
    {
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        character = GameObject.Find("/XR/XR Origin");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
        plan1=false;
    }

    public void OnClickButton()
    {   
        CharacterController cc = character.GetComponent<CharacterController>();
        if (name == "FPButton1")
        {
            cc.enabled = false;
            character.transform.position = new Vector3(1.5f+3.22f,1.52f,25-2.75f);
            character.transform.rotation = Quaternion.Euler(0, -90, 0);
<<<<<<< Updated upstream
            cc.enabled = true;
=======
            plan1=true;
>>>>>>> Stashed changes
        }
        else if (name == "FPButton2")
        {
            cc.enabled = false;
            character.transform.position = new Vector3(3,1.52f,-30);
            cc.enabled = true;
        }
        floorPlanMenu.SetActive(false);
        searchMenu.SetActive(false);
        apartmentsMenu.SetActive(false);
    }

}
