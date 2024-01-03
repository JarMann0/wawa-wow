using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour { 
    public float timer;
    //EARLY VERSION OF PULSATING
    public GameObject picture1;
    public GameObject picture2;
    public GameObject picture3;
    public GameObject picture4;
    public GameObject picture5;
    public GameObject picture6;
    public GameObject picture7;
    public GameObject picture8;
    public GameObject picture9;
    public GameObject picture10;
    public GameObject picture11;
    public GameObject picture12;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.6)
        {
            timer = 0;
        }

        if (timer <= 0.05f)
        {
            picture1.SetActive(true);
        }
        else
        {
            picture1.SetActive(false);
        }
        if (timer <= 0.099f && timer > 0.05f)
        {
            picture2.SetActive(true);
        }
        else
        {
            picture2.SetActive(false);
        }
        if (timer <= 0.149f && timer > 0.1f)
        {
            picture3.SetActive(true);
        }
        else
        {
            picture3.SetActive(false);
        }
        if (timer <= 0.199f && timer > 0.15f)
        {
            picture4.SetActive(true);
        }
        else
        {
            picture4.SetActive(false);
        }
        if (timer <= 0.249 && timer > 0.2f)
        {
            picture5.SetActive(true);
        }
        else
        {
            picture5.SetActive(false);
        }
        if (timer > 0.299f && timer > 0.25f)
        {
            picture6.SetActive(true);
        }
        else
        {
            picture6.SetActive(false);
        }
        if (timer > 0.349f && timer > 0.3f)
        {
            picture7.SetActive(true);
        }
        else
        {
            picture7.SetActive(false);
        }
        if (timer > 0.399f && timer > 0.35f)
        {
            picture8.SetActive(true);
        }
        else
        {
            picture8.SetActive(false);
        }
        if (timer <= 0.449f && timer > 0.4f)
        {
            picture9.SetActive(true);
        }
        else
        {
            picture9.SetActive(false);
        }
        if (timer <= 0.499f && timer > 0.45f)
        {
            picture10.SetActive(true);
        }
        else
        {
            picture10.SetActive(false);
        }
        if (timer <= 0.5499f && timer > 0.5f)
        {
            picture11.SetActive(true);
        }
        else
        {
            picture11.SetActive(false);
        }
        if (timer <= 0.599f && timer > 0.55f)
        {
            picture12.SetActive(true);
        }
        else
        {
            picture12.SetActive(false);
        }

    }
}
