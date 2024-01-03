using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialText : MonoBehaviour
{
    public Key rd;
    public swordScript ss;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (rd.WasKeyCollected == true)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
        }
        if (ss.swordWasCollected == true)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
        }
    }
}
