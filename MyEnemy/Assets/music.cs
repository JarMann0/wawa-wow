using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public GameObject m;
    public movementAndDeath mad;

    // Start is called before the first frame update
    void Start()
    {
        m.SetActive(true);
        mad = GameObject.FindGameObjectWithTag("Plauer").GetComponent<movementAndDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mad.die == true)
        {
            m.SetActive(false);
        }
    }
}
