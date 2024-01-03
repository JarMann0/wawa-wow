using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public Transform m;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        m.transform.rotation = rotation;
    }
    // Update is called once per frame
    void Update()
    {
        LAMouse();
    }
}
