using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoor : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject floorPlanMenu;
    private GameObject character;
    void Start()
    {
        character = GameObject.Find("/XR");
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        floorPlanMenu = GameObject.Find("/Main UI Group/FloorPlanCanvas/Floor Plan UI");
    }
    // Start is called before the first frame update
    public void OnDoorSelect()
    {
        character.transform.position = new Vector3(32, 1.5f, 0);
        character.transform.rotation = Quaternion.Euler(0, -90, 0);
        searchMenu.SetActive(false);
        apartmentsMenu.SetActive(false);
        floorPlanMenu.SetActive(true);
    }
}
