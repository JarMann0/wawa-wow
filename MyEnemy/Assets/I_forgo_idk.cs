using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_forgo_idk : MonoBehaviour
{
    public bool hasPlayerMoved;
    public movementAndDeath mad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayerMoved)
        {
            PlayerPrefs.SetInt("speedrun", 1);
            this.gameObject.SetActive(false);
        }
    }
}
