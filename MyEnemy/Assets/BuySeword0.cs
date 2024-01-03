using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySeword0 : MonoBehaviour
{
    // IMPORTANT
    // sSkin 0 = normal sword , 1 = spoon , 2 = toilet sword , 3 = milb
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("sSkin", 0) == 0)
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
        if (PlayerPrefs.GetInt("sSkin", 0) == 0)
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
        PlayerPrefs.SetInt("sSkin", 0);
        print("equipped sword");
    }
}
