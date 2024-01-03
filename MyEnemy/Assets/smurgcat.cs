using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smurgcat : MonoBehaviour
{
    public GameObject smurfcat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sW - smurf Cat wawa
        if (PlayerPrefs.GetInt("sW", 0) == 1)
        {
            smurfcat.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
