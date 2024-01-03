using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueee : MonoBehaviour
{
    public GameObject dialogueWindow;
    public GameObject myself;
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
        myself.SetActive(false);
        dialogueWindow.SetActive(true);
    }
}
