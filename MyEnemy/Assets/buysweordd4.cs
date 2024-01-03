using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buysweordd4 : MonoBehaviour
{
    // IMPORTANT
    // sSkin 0 = normal sword , 1 = spoon , 2 = toilet sword , 3 = milb , 4 = crosier
    public CoinManager cm;
    public GameObject textCost;
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("cS", 0));
        // ts - toilet sword
        if (PlayerPrefs.GetInt("cS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) == 4)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("cS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) != 4)
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
        if (PlayerPrefs.GetInt("cS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) == 4)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("cS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) != 4)
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
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("cS", 0) == 0)
        {
            PlayerPrefs.SetInt("cS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 4);
            print("equipped crosier sword");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("cS", 0) == 0)
        {
            PlayerPrefs.SetInt("cS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 4);
            print("equipped crosier sword");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("cS", 0) == 0)
        {
            PlayerPrefs.SetInt("cS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 4);
            print("equipped crosier sword");
        }
    }
}
