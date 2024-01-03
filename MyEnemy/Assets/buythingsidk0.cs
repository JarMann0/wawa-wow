using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buythingsidk0 : MonoBehaviour
{
    // IMPORTANT
    // wSkin 0 = normal wawa , 1 = cowboy wawa , 2 = pixelated wawa , 3 = smurfcat wawa
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("wSkin", 0) == 0)
        {
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else
        {
            textOwned.SetActive(true);
            textEquipped.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("wSkin", 0) == 0)
        {
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else
        {
            textOwned.SetActive(true);
            textEquipped.SetActive(false);
        }
    }

    public void EquipSkin()
    {
           PlayerPrefs.SetInt("wSkin", 0);
           print("equipped wawa");
    }
}
