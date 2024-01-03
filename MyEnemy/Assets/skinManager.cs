using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinManager : MonoBehaviour
{
    // defualt sword
    public GameObject dS;
    // spoon sword
    public GameObject sS;
    // toilet sword
    public GameObject tS;
    // milb sword
    public GameObject mS;
    // bishop sword
    public GameObject bS;
    // defualt wawa
    public GameObject dW;
    // cowboy wawa
    public GameObject cW;
    // pixelated wawa
    public GameObject pW;
    // smurfcat wawa
    public GameObject sW;
    // bishop wawa
    public GameObject bW;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("sSkin", 0) == 0)
        {
            dS.SetActive(true);
            sS.SetActive(false);
            tS.SetActive(false);
            mS.SetActive(false);
            bS.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sSkin", 0) == 1)
        {
            dS.SetActive(false);
            sS.SetActive(true);
            tS.SetActive(false);
            mS.SetActive(false);
            bS.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sSkin", 0) == 2)
        {
            dS.SetActive(false);
            sS.SetActive(false);
            tS.SetActive(true);
            mS.SetActive(false);
            bS.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sSkin", 0) == 3)
        {
            dS.SetActive(false);
            sS.SetActive(false);
            tS.SetActive(false);
            mS.SetActive(true);
            bS.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("sSkin", 0) == 4)
        {
            dS.SetActive(false);
            sS.SetActive(false);
            tS.SetActive(false);
            mS.SetActive(false);
            bS.SetActive(true);
        }

        if (PlayerPrefs.GetInt("wSkin", 0) == 0)
        {
            dW.SetActive(true);
            cW.SetActive(false);
            pW.SetActive(false);
            sW.SetActive(false);
            bW.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("wSkin", 0) == 1)
        {
            dW.SetActive(false);
            cW.SetActive(true);
            pW.SetActive(false);
            sW.SetActive(false);
            bW.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("wSkin", 0) == 2)
        {
            dW.SetActive(false);
            cW.SetActive(false);
            pW.SetActive(true);
            sW.SetActive(false);
            bW.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("wSkin", 0) == 3)
        {
            dW.SetActive(false);
            cW.SetActive(false);
            pW.SetActive(false);
            sW.SetActive(true);
            bW.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("wSkin", 0) == 4)
        {
            dW.SetActive(false);
            cW.SetActive(false);
            pW.SetActive(false);
            sW.SetActive(false);
            bW.SetActive(true);
        }
    }
}
