using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buythingsikd2 : MonoBehaviour
{
    // IMPORTANT
    // wSkin 0 = normal wawa , 1 = cowboy wawa , 2 = pixelated wawa , 3 = smurfcat wawa , 4 = bishop wawa
    public CoinManager cm;
    public GameObject textCost;
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("pW", 0));
        // pW - pixelated wawa
        if (PlayerPrefs.GetInt("pW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) == 2)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("pW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) != 2)
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
        if (PlayerPrefs.GetInt("pW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) == 2)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("pW", 0) == 1 && PlayerPrefs.GetInt("wSkin", 0) != 2)
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
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("pW", 0) == 0)
        {
            PlayerPrefs.SetInt("pW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("pW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 2);
            print("equipped pixelated wawa");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("pW", 0) == 0)
        {
            PlayerPrefs.SetInt("pW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("pW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 2);
            print("equipped pixelated wawa");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("pW", 0) == 0)
        {
            PlayerPrefs.SetInt("pW", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("pW", 0) == 1)
        {
            PlayerPrefs.SetInt("wSkin", 2);
            print("equipped pixelated wawa");
        }
    }
}
