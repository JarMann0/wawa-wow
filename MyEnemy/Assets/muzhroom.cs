using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzhroom : MonoBehaviour
{
    public GameObject top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("sW", 1);
        this.GetComponent<Renderer>().material.color = new UnityEngine.Color(
            this.GetComponent<Renderer>().material.color.r, this.GetComponent<Renderer>().material.color.g,this.GetComponent<Renderer>().material.color.b,100f);
        top.GetComponent<Renderer>().material.color = new UnityEngine.Color(
            this.GetComponent<Renderer>().material.color.r, this.GetComponent<Renderer>().material.color.g, this.GetComponent<Renderer>().material.color.b, 100f);
        
    }
}
