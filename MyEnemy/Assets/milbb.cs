using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milbb : MonoBehaviour
{
    public GameObject milb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // mS - milb skin
        if (PlayerPrefs.GetInt("mS", 0) == 1)
        {
            milb.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
