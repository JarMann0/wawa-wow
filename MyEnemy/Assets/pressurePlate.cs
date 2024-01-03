using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public GameObject trapDoor;
    public bool activatedOnce;
    // Start is called before the first frame update
    void Start()
    {
        activatedOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (activatedOnce == false)
        {
            activatedOnce = true;
            trapDoor.SetActive(true);
        }
    }
}
