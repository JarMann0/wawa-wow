using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buySwordzidk3 : MonoBehaviour
{
    // IMPORTANT
    // sSkin 0 = normal sword , 1 = spoon , 2 = toilet sword , 3 = milb , 4 = crosier
    public CoinManager cm;
    public GameObject textOwned;
    public GameObject textEquipped;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("mS", 0));
        // mS - milb (Skin)
        if (PlayerPrefs.GetInt("sSkin", 0) == 3)
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
        if (PlayerPrefs.GetInt("sSkin", 0) == 3)
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
        if (PlayerPrefs.GetInt("coins", 0) >= 50 && PlayerPrefs.GetInt("mS", 0) == 0)
        {
            PlayerPrefs.SetInt("mS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 50);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("mS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 3);
            print("equipped milb");
        }
    }

    public void BuyCostlySkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 150 && PlayerPrefs.GetInt("mS", 0) == 0)
        {
            PlayerPrefs.SetInt("mS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 150);

            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("mS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 3);
            print("equipped milb");
        }
    }

    public void BuyExpensiveSkin()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 300 && PlayerPrefs.GetInt("mS", 0) == 0)
        {
            PlayerPrefs.SetInt("mS", 1);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) - 300);
            textOwned.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("mS", 0) == 1)
        {
            PlayerPrefs.SetInt("sSkin", 3);
            print("equipped milb");
        }
    }
}
