using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject myself;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public float timer;
    public bool StartMoving;
    // Start is called before the first frame update
    void Start()
    {
        StartMoving = false;

        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4 && timer < 8)
        {
            text2.SetActive(true);
            text3.SetActive(false);
            text1.SetActive(false);
        }
        if (timer > 8 && timer < 11)
        {
            text2.SetActive(false);
            text3.SetActive(true);
            text1.SetActive(false);
        }
        if (timer > 11)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            myself.SetActive(false);
            StartMoving = true;
        }
    }
}
