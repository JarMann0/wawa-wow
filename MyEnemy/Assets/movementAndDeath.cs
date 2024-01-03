using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movementAndDeath : MonoBehaviour
{
    private float movementH;
    private float movementV;
    public float speed;
    public Rigidbody2D rb;
    public float timer;
    public float e;
    public float f;
    public bool speedrunactive;
    public PauseMenu pm;
    // false = wawa alive , true = wawa dead
    public bool die;
    public Vector2 Distance;
    public bool playtimer;
    //if its false the player is facing right if its true the player is facing left
    public bool playerDirection;
    public Joystick wawastick;

    // Start is called before the first frame update

    void Start()
    {
        playtimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("speedrun", 0) == 1)
        {
            speedrunactive = true;
        }
        if (PlayerPrefs.GetInt("speedrunWaiting", 0) == 1)
        {
            //print("Waiting");
            if (movementH != 0 || movementV != 0) 
            {
                //print("moved");
                PlayerPrefs.SetInt("speedrunWaiting", 0);
                PlayerPrefs.SetInt("speedrun", 1);
                //print("set speedrun to true");
            }

        }
        if (die == true && speedrunactive == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
         else if (die == true && speedrunactive == true)
        {
            SceneManager.LoadScene("Level 1 speedrun");
            PlayerPrefs.SetFloat("timer", 0);
            PlayerPrefs.SetInt("speedrunWaiting", 1);
            PlayerPrefs.SetInt("speedrun", 0);
        }
        if (die == false && pm.GameIsPaused == false && PlayerPrefs.GetInt("mobile", 1) == 0)
        {
            movementH = Input.GetAxisRaw("Horizontal");
            movementV = Input.GetAxisRaw("Vertical");
        }
        else if (die == false && pm.GameIsPaused == false && PlayerPrefs.GetInt("mobile", 1) == 1)
        {
            movementH = wawastick.Horizontal;
            movementV = wawastick.Vertical;
        }
        else
        {
            movementH = 0;
            movementV = 0;
        }

        if (Input.GetKeyDown(KeyCode.D)&& pm.GameIsPaused == false)
        {
            playerDirection = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true && pm.GameIsPaused == false)
        {
            playerDirection = false;
        }

        if (PlayerPrefs.GetInt("mobile", 0) == 0)
        {
            if (Input.GetKeyDown(KeyCode.A) && pm.GameIsPaused == false)
            {
                playerDirection = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true && pm.GameIsPaused == false)
            {
                playerDirection = true;
            }
            if (Input.GetKeyDown(KeyCode.D) && pm.GameIsPaused == false)
            {
                playerDirection = false;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) == true && pm.GameIsPaused == false)
            {
                playerDirection = false;
            }
        }
        if (PlayerPrefs.GetInt("mobile", 0) == 1)
        {
            if (wawastick.Horizontal < 0 && pm.GameIsPaused == false)
            {
                playerDirection = true;
            }
            if (Input.GetKeyDown(KeyCode.D) && pm.GameIsPaused == false)
            {
                playerDirection = false;
            }
            if (wawastick.Horizontal > 0 && pm.GameIsPaused == false)
            {
                playerDirection = false;
            }
        }

        if (playerDirection == false && pm.GameIsPaused == false)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }


        if (playtimer == true && pm.GameIsPaused == false)
        {
          timer = timer + Time.deltaTime;
        }
        if (timer > 0.2f)
        {
            timer = 0;
        }

        if (timer <= 0.1f)
        {
            e = 1.85f;
            f = 2.15f;
        }
        if (timer > 0.1f)
        {
            e = 2.15f;
            f = 1.85f;
        }


        rb.velocity = new Vector2(movementH * speed,movementV * speed);

        if (movementH != 0 || movementV != 0 && pm.GameIsPaused == false)
        {
            rb.transform.localScale = new Vector2(f, e);
        }
        else if (pm.GameIsPaused == false)
        {
            rb.transform.localScale = new Vector2(2, 2);
        }

    }

}
