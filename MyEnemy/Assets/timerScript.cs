using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI text;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        timer = PlayerPrefs.GetFloat("timer", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("speedrun", 0) == 1)
        {
            //print("spreedrun is acriver");
            timer = PlayerPrefs.GetFloat("timer", 0);
            time = Time.deltaTime;
            timer = Mathf.Round(timer * 100.0f) * 0.01f;
            PlayerPrefs.SetFloat("timer", PlayerPrefs.GetFloat("timer", 0) + time);
            text.text = timer.ToString();
            //print("new value assigned to timer");
        }
        else
        {
            text.text = timer.ToString();
            //print("speedrun not active");
        }
    }

}
