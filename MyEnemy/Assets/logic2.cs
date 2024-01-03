using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logic2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void quit()
    {

    }
    public void mainmenu()
    {
        SceneManager.LoadScene(1);
    }
    public void DONT()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
