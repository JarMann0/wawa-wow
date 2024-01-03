using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyThingsIdk : MonoBehaviour
{
    // IMPORTANT
    // wSkin 0 = normal wawa , 1 = cowboy wawa , 2 = pixelated wawa , 3 = smurfcat wawa
    public CoinManager cm;
    public GameObject textCost;
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("cW", 0));
        // cw - cowboy wawa
        if (PlayerPrefs.GetInt("cW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) == 1)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("cW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) != 1)
        {
            textCost.SetActive(false);
            textOwned.SetActive(true);
            textEquipped.SetActive(false);
        }
        else
        {
            textCost.SetActive(true);
            textOwned.SetActive(false);
            textEquipped.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("cW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) == 1)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("cW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) != 1)
        {
            textCost.SetActive(false);
            textOwned.SetActive(true);
            textEquipped.SetActive(false);
        }
        else
        {
            textCost.SetActive(true);
            textOwned.SetActive(false);
            textEquipped.SetActive(false);
        }
    }

    public void BuyNormalSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("cW", 0) == 0)
        {
            PlayerPrefs.SetInt("cW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 1);
            print("equipped cowboy wawa");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("cW", 0) == 0)
        {
            PlayerPrefs.SetInt("cW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cW", 0) == 1)
        {
            //equips skin
            print("equipped cowboy wawa");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("cW", 0) == 0)
        {
            PlayerPrefs.SetInt("cW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cW", 0) == 1)
        {
            //equips skin
            print("equipped cowboy wawa");
        }
    }
}
