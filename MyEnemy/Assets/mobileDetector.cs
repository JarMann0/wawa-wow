using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileDetector : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("mobile", 0) == 1)
        {
            a.SetActive(true);
            b.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("mobile", 0) == 0)
        {
            a.SetActive(false);
            b.SetActive(false);
        }
    }
}
