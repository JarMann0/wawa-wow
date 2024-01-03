using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class swordScript : MonoBehaviour
{
    public GameObject CollectableSword;
    public GameObject PlayerEqSword;
    public bool swordWasCollected;

    // Start is called before the first frame update
    void Start()
    {
        swordWasCollected = false;
        CollectableSword.SetActive(true);
        PlayerEqSword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Plauer"))
        {
            CollectableSword.SetActive(false);
            PlayerEqSword.SetActive(true);
            swordWasCollected = true;
        }
    }
}
