using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShopOpen : MonoBehaviour
{
    public GameObject myself;
    public bool ActiveOrNot;
    // Start is called before the first frame update
    void Start()
    {
        myself.SetActive(ActiveOrNot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
