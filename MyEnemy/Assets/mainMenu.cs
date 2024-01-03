using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Toggle toggle;
    public startM audiooo;
    // use the // when realising a demo to wipe the data
    private void Start()
    {
        //remember to un-comment mobile 1 on mobile version , and mobile 0 on pc version !!!
        //mobile 1 = mobile version , mobile 0 = pc version
        //PlayerPrefs.SetInt("mobile", 1);
        PlayerPrefs.SetInt("mobile", 0);

        Application.targetFrameRate = 60;
        PlayerPrefs.SetInt("speedrun", 0);
        PlayerPrefs.SetFloat("timer", 0);

        Application.targetFrameRate = 60;
    }
    public void WawaButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void DONT()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
