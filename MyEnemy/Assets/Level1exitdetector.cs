using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1exitdetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Plauer"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PlayerPrefs.SetInt("level1", 1);
            }
            if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PlayerPrefs.SetInt("level2", 1);
            }
            if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                PlayerPrefs.SetInt("level3", 1);
            }
            if (SceneManager.GetActiveScene().buildIndex == 15)
            {
                PlayerPrefs.SetInt("level4", 1);
            }
            Debug.Log("player has escaped");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + 10);
        }
    }
}
