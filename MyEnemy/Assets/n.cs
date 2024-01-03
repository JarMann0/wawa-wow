using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class n : MonoBehaviour
{
    public float nClicks;
    public GameObject secret;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        nClicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void N()
    {
        nClicks++;
        if (nClicks != 10)
        {
            return;
            
        }
        button.SetActive(false);
        secret.SetActive(true);
    }
    public void NRESET()
    {
        nClicks = 0;
    }
}
