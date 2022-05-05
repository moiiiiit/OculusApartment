using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject mainUIGroup;
    private GameObject character;
    private GameObject backButton;
    private CharacterController cc;
    
    // Start is called before the first frame update
    void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        character = GameObject.Find("/XR/XR Origin");
        CharacterController cc = character.GetComponent<CharacterController>();
        cc.enabled = false;
        character.transform.position = new Vector3(32-1.65f,1.52f,-2.38f);
        character.transform.rotation = Quaternion.Euler(0, -90, 0);
        cc.enabled = true;
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
        backButton = GameObject.Find("/Main UI Group/BackButtonCanvas/BackButton");
        searchMenu.SetActive(true);
        apartmentsMenu.SetActive(false);
        floorPlanMenu.SetActive(false);
        backButton.SetActive(false);
    }
}
