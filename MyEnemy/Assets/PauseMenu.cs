using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseButton;
    public GameObject pausemenu;
    public GameObject attackButton;
    public swordScript ss;
    public Vector3 efwf;
    private void Start()
    {
        efwf = attackButton.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (ss.swordWasCollected == false)
        {
            attackButton.transform.position = new Vector3(2312324, 42424, 2432234324);
        }
        if (ss.swordWasCollected == true)
        {
            attackButton.transform.position = efwf;
        }
    }

    public void pauseGame()
    {
        GameIsPaused = true;
        pausemenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void unpauseGame()
    {
        GameIsPaused = false;
        pausemenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void LevelSelector()
    {
        SceneManager.LoadScene(1);
    }
    public void DONT()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void EndSpeedrun()
    {
        PlayerPrefs.SetInt("speedrun", 0);
        PlayerPrefs.SetInt("speedrun", 0);
        PlayerPrefs.SetFloat("timer", 0);
        SceneManager.LoadScene(1);
        PlayerPrefs.SetFloat("timer", 0);

    }
}
