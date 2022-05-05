using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchMenu : MonoBehaviour
{
    private GameObject searchMenu;
    private GameObject apartmentsMenu;
    private GameObject backButton;
    
    // Start is called before the first frame update
    void Start()
    {
        searchMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Search UI");
        apartmentsMenu = GameObject.Find("/Main UI Group/MainMenuCanvas/Apartments UI");
        
    }

    public void OnClickButton()
    {
        if (name == "Search")
        {
            backButton = GameObject.Find("/Main UI Group/BackButtonCanvas/BackButton");
            searchMenu.SetActive(false);
            apartmentsMenu.SetActive(true);
            backButton.SetActive(true);
        }
    }
}
