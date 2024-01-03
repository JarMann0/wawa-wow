using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    public movementAndDeath mad;
    public GameObject myself;
    // Start is called before the first frame update
    void Start()
    {
        mad = GameObject.FindGameObjectWithTag("Plauer").GetComponent<movementAndDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mad.die == true)
        {
            myself.SetActive(false);
        }
    }
}
