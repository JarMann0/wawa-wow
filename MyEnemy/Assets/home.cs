using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void homee()
    {
        PlayerPrefs.SetInt("speedrun", 0);
        PlayerPrefs.SetInt("timer", 0);
        SceneManager.LoadScene(1);
    }
}
