using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public movementAndDeath mv;
    public Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb.position = mv.rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.position = mv.rb.position;
    }
}
