using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class swordMelee : MonoBehaviour
{
    public swordScript ss;
    public movementAndDeath mad;
    public SpriteShapeRenderer cooleffect;
    public GameObject go;
    public Material ok;
    public float timer;
    public bool startTimer;
    public bool duringattack;
    public hitdet hd;
    public GameObject hdp;
    public PauseMenu pm;
    
    // Start is called before the first frame update
    void Start()
    {
        startTimer = false;
        transform.rotation = Quaternion.Euler(0, 0, 20);
        cooleffect.color = new Color(1, 1, 1, 0);
        duringattack = false;
        hdp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true && pm.GameIsPaused == false)
        {
            timer = timer + Time.deltaTime;
            if (timer > 0.5)
            {
                hdp.SetActive(false);
                startTimer = false;
                timer = 0;
                duringattack = false;
                hd.cantAttackTwiceBozo = false;
                if (mad.playerDirection == true)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 20);
                    cooleffect.color = new Color(1, 1, 1, 0);
                }
                else if (mad.playerDirection == false)
                {
                    transform.rotation = Quaternion.Euler(0, 0, -20);
                    cooleffect.color = new Color(1, 1, 1, 0);
                }
            }
        }

        if (ss.swordWasCollected == true && Input.GetKeyDown(KeyCode.Mouse0) && mad.die == false && pm.GameIsPaused == false && PlayerPrefs.GetInt("mobile", 0) == 0)
        {
            attack();

        }
    }

    public void attack()
    {
        hdp.SetActive(true);
        startTimer = true;
        duringattack = true;
        if (mad.playerDirection == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 140);
            cooleffect.color = new Color(1, 1, 1, 0.1f);
        }
        else if (mad.playerDirection == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, -140);
            cooleffect.color = new Color(1, 1, 1, 0.1f);
        }
    }

    public void attackbutton()
    {
        if (ss.swordWasCollected == true && mad.die == false && pm.GameIsPaused == false && PlayerPrefs.GetInt("mobile", 0) == 1)
        {
            attack();
        }
    }
}
