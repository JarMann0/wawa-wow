using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySwoerd2 : MonoBehaviour
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
        print(PlayerPrefs.GetInt("tS", 0));
        // ts - toilet sword
        if (PlayerPrefs.GetInt("tS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) == 2)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("tS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) != 2)
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
        if (PlayerPrefs.GetInt("tS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) == 2)
        {
            textCost.SetActive(false);
            textOwned.SetActive(false);
            textEquipped.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("tS", 0) == 1 && PlayerPrefs.GetInt("sSkin", 0) != 2)
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
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("tS", 0) == 0)
        {
            PlayerPrefs.SetInt("tS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("tS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 2);
            print("equipped toilet sword");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("tS", 0) == 0)
        {
            PlayerPrefs.SetInt("tS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("tS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 2);
            print("equipped toilet sword");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("tS", 0) == 0)
        {
            PlayerPrefs.SetInt("tS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textCost.SetActive(true);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("tS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 2);
            print("equipped toilet sword");
        }
    }
}
