using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float maxhealth;
    public float currenthealth;
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public bool ismaxhp;
    public movementAndDeath mv;
    
    // Start is called before the first frame update
    void Start()
    {
        maxhealth = 3;
        currenthealth = maxhealth;
        h1.SetActive(true);
        h2.SetActive(true);
        h3.SetActive(true);
        mv = GameObject.FindGameObjectWithTag("Plauer").GetComponent<movementAndDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth == 3)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(true);
        }
        else if (currenthealth == 2)
        {
            h1.SetActive(true);
            h2.SetActive(true);
            h3.SetActive(false);
        }
        else if (currenthealth == 1)
        {
            h1.SetActive(true);
            h2.SetActive(false);
            h3.SetActive(false);
        }
        else if (currenthealth == 0)
        {
            h1.SetActive(false);
            h2.SetActive(false);
            h3.SetActive(false);
        }
    }

    public void increasehp ()
    {
        if (currenthealth == 3)
        {
            ismaxhp = true;
            return;
        }
        else
        {
            ismaxhp = false;
            currenthealth++;
        }
    }

    public void decreaseHp(int damageTaken)
    {
        currenthealth = currenthealth - damageTaken;
        if (currenthealth == 0)
        {
            mv.die = true;
            mv.rb.velocity = Vector2.zero;
            mv.playtimer = false;
            mv.f = 2;
            mv.e = 2;
        }
        
    }
}
