using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("mobile", 0));
        if (PlayerPrefs.GetInt("mobile", 0) == 1)
        {
            this.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            this.GetComponent<Toggle>().isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
