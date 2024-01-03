using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class pulsating : MonoBehaviour
{
    public float timer;
    // wawa size multiplier
    public float e;
    public float f;
    public Transform wawa;
    // original wawa size
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        x = wawa.localScale.x;
        y = wawa.localScale.y;
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
            e = 1.7f;
            f = 2.3f;
        }
        if (timer <= 0.1f && timer > 0.05f)
        {
            e = 1.8f;
            f = 2.2f;
        }
        if (timer <= 0.15f && timer > 0.1f)
        {
            e = 1.9f;
            f = 2.1f;
        }
        if (timer <= 0.2f && timer > 0.15f)
        {
            e = 2;
            f = 2;
        }
        if (timer <= 0.25 && timer > 0.2f)
        {
            e = 2.1f;
            f = 1.9f;
        }
        if (timer > 0.3f && timer > 0.25f)
        {
            e = 2.2f;
            f = 1.8f;
        }
        if (timer > 0.35f && timer > 0.3f)
        {
            e = 2.3f;
            f = 1.7f;
        }
        if (timer > 0.4f && timer > 0.35f)
        {
            e = 2.2f;
            f = 1.8f;
        }
        if (timer <= 0.45f && timer > 0.4f)
        {
            e = 2.1f;
            f = 1.9f;
        }
        if (timer <= 0.5f && timer > 0.45f)
        {
            e = 2;
            f = 2;
        }
        if (timer <= 0.55f && timer > 0.5f)
        {
            e = 1.9f;
            f = 2.1f;
        }
        if (timer <= 0.6f && timer > 0.55f)
        {
            e = 1.8f;
            f = 2.2f;
        }

        wawa.localScale = new Vector2(x * e / 2, y * f / 2);
    }
}
