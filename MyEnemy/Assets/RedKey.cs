using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool BlackKey;
    public bool WasKeyCollected;
    public GameObject k;
    public GameObject dGameObject;
    // Start is called before the first frame update
    void Start()
    {
        if (BlackKey == true)
        {
            dGameObject = GameObject.FindGameObjectWithTag("black");
        }
        WasKeyCollected = false;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Plauer"))
        {
            WasKeyCollected = true;
            k.SetActive(false);
            dGameObject.SetActive(false);
        }
    }
}
