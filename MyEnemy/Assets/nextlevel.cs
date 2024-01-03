using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void restartSpeedrun()
    {
        SceneManager.LoadScene("Level 1 speedrun");
        PlayerPrefs.SetInt("speedrun", 1);
        PlayerPrefs.SetInt("timer", 0);
        
    }
}
