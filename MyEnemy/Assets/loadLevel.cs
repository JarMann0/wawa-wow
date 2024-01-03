using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1()
    {
        SceneManager.LoadScene(6);
    }
    public void Level2()
    {
        if (PlayerPrefs.GetInt("level1", 0) == 1)
        {
            SceneManager.LoadScene(9);
        }    
    }

    public void Level3()
    {
        if (PlayerPrefs.GetInt("level2", 0) == 1) // rember to set the 0 to 1 when finish make the scripts
        {
            SceneManager.LoadScene(12);
        }
    }
    public void Level4()
    {
        if (PlayerPrefs.GetInt("level3", 0) == 1) // rember to set the 0 to 1 when finish make the scripts
        {
            SceneManager.LoadScene(15);
        }
    }

    public void Shop()
    {
        SceneManager.LoadScene(3);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(2);
    }
    public void Speedrun()
    {
        SceneManager.LoadScene("Level 1 speedrun");
        PlayerPrefs.SetFloat("timer", 0);
        PlayerPrefs.SetInt("speedrunWaiting", 1);
    }
}
