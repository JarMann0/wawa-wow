using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicTF2 : MonoBehaviour
{
    public health h;
    public GameObject myself;
    // Start is called before the first frame update
    void Start()
    {
        h = GameObject.FindGameObjectWithTag("Plauer").GetComponent<health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Plauer"))
        {
            h.increasehp();
            if (h.ismaxhp == false)
            {
                myself.SetActive(false);
            }
        }
    }
}
