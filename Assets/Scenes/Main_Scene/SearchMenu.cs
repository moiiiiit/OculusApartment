using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchMenu : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnClickButton()
    {
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        if (name == "Search")
        {
            searchMenu.SetActive(false);
            apartmentsMenu.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
