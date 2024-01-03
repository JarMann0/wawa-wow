using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Npc : MonoBehaviour
{
    public GameObject exit;
    public GameObject me;
    public panel panel;
    public GameObject pointA;
    public GameObject pointB;
    bool b;
    public float timer;
    public float timer2;
    // Start is called before the first frame update
    void Start()
    {
        b = false;
        timer = 0;
        timer2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.StartMoving == true && b == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.transform.position, 7f * Time.deltaTime);
            timer += Time.deltaTime;
        }
        if (timer > 25 || b == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointB.transform.position, 7f * Time.deltaTime);
            b = true;
            timer2 += Time.deltaTime;
        }
        if (timer2 > 6)
        {
            this.gameObject.SetActive(false);
        }


    }
}
