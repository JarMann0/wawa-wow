using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buythingsidk3 : MonoBehaviour
{
    // IMPORTANT
    // wSkin 0 = normal wawa , 1 = cowboy wawa , 2 = pixelated wawa , 3 = smurfcat wawa
    public CoinManager cm;
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("sW", 0));
        // sW - smurfcat wawa
        if (PlayerPrefs.GetInt("wSkin", 0) == 3)
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
        if (PlayerPrefs.GetInt("wSkin", 0) == 3)
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

    public void BuyNormalSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("sW", 0) == 0)
        {
            PlayerPrefs.SetInt("sW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 3);
            print("equipped smurfcat wawa");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("sW", 0) == 0)
        {
            PlayerPrefs.SetInt("sW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 3);
            print("equipped smurfcat wawa");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("sW", 0) == 0)
        {
            PlayerPrefs.SetInt("sW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 3);
            print("equipped smurfcat wawa");
        }
    }
}
