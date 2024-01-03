using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class devScript : MonoBehaviour
{
    public Toggle toggle;
    public mainMenu menu;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ResetData()
    {
        PlayerPrefs.SetInt("level1", 0);
        PlayerPrefs.SetInt("level2", 0);
        PlayerPrefs.SetInt("level3", 0);
        PlayerPrefs.SetInt("level4", 0);
        menu.audiooo.mixer.SetFloat("volume", -5);
        SceneManager.LoadScene(0);
        slider.value = -5;
        // remember to set this to 1 in mobile version lol
        PlayerPrefs.SetInt("real", 0);
        PlayerPrefs.SetInt("coins", 0);
        PlayerPrefs.SetInt("pW", 0);
        PlayerPrefs.SetInt("cW", 0);
        PlayerPrefs.SetInt("bW", 0);
        PlayerPrefs.SetInt("wSkin", 0);
        PlayerPrefs.SetInt("sS", 0);
        PlayerPrefs.SetInt("tS", 0);
        PlayerPrefs.SetInt("cS", 0);
        PlayerPrefs.SetInt("sSkin", 0);
    }
    public void UnlockAll()
    {
        PlayerPrefs.SetInt("level1", 1);
        PlayerPrefs.SetInt("level2", 1);
        PlayerPrefs.SetInt("level3", 1);
        PlayerPrefs.SetInt("level4", 1);
    }

    public void TenMoreCoins()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + 10);
    }
    public void ResetCoins()
    {
        PlayerPrefs.SetInt("coins", 0);
    }

    public void ResetSkins()
    {
        PlayerPrefs.SetInt("pW", 0);
        PlayerPrefs.SetInt("cW", 0);
        PlayerPrefs.SetInt("sW", 0);
        PlayerPrefs.SetInt("bW", 0);
        PlayerPrefs.SetInt("wSkin", 0);
        PlayerPrefs.SetInt("sS", 0);
        PlayerPrefs.SetInt("tS", 0);
        PlayerPrefs.SetInt("mS", 0);
        PlayerPrefs.SetInt("cS", 0);
        PlayerPrefs.SetInt("sSkin", 0);
    }
    public void GetAllSkins()
    {
        PlayerPrefs.SetInt("pW", 1);
        PlayerPrefs.SetInt("cW", 1);
        PlayerPrefs.SetInt("sW", 1);
        PlayerPrefs.SetInt("bW", 1);
        PlayerPrefs.SetInt("wSkin", 0);
        PlayerPrefs.SetInt("sS",1);
        PlayerPrefs.SetInt("tS", 1);
        PlayerPrefs.SetInt("mS", 1);
        PlayerPrefs.SetInt("cS", 1);
        PlayerPrefs.SetInt("sSkin", 0);
    }
}
