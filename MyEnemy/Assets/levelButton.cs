using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelButton : MonoBehaviour
{
    // level means which level button it is , for example level 3 means it is the button for level 3 
    public int levelbutton;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("level1", 0) == 1 && levelbutton == 2)
        {
            button.interactable = true;
        }
        if (PlayerPrefs.GetInt("level2", 0) == 1 && levelbutton == 3)
        {
            button.interactable = true;
        }
        if (PlayerPrefs.GetInt("level3", 0) == 1 && levelbutton == 4)
        {
            button.interactable = true;
        }
        if (PlayerPrefs.GetInt("level4", 0) == 1 && levelbutton == 0)
        {
            button.interactable = true;
        }
    }
}
