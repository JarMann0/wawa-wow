using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class fastEnemy : MonoBehaviour
{
    //useful code for the future


    //distance = Vector2.Distance(transform.position, player.transform.position);
    //    Vector2 direction = player.transform.position - transform.position;
    //
    //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //
    //if (mv.die != true && distance<ndistance)
    //{
    //    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed* Time.deltaTime);
    //transform.rotation = Quaternion.Euler(Vector3.forward* angle);
    //}


    //transform.rotation = Quaternion.Euler(0, 0, 0);




    public movementAndDeath mv;
    public LayerMask layermask;
    public int distancee;
    public Rigidbody2D rb;
    public GameObject player;
    public float speed;
    public GameObject enemySprite;
    public GameObject square;
    public health healt;
    public float timer;
    public bool starttimer;
    public GameObject H1;
    public GameObject enemy;
    public bool hitonce;
    public int healther;
    public bool startTimer2;
    public float timer2;
    public PauseMenu pm;
    private float distance;
    // distance from which enemy notices you
    public float ndistance;
    // distance from which enemy kills you
    public float kdistance;
    public Vector3 startPosition;
    public UnityEngine.Color colorr;
    public UnityEngine.Color enemyHidden;
    public UnityEngine.Color enemyAttacking;

    void Start()
    {
        startPosition = transform.position;
        healt = GameObject.FindGameObjectWithTag("Plauer").GetComponent<health>();
        player = GameObject.FindGameObjectWithTag("Plauer");
        mv = GameObject.FindGameObjectWithTag("Plauer").GetComponent<movementAndDeath>();
        starttimer = false;
        healther = 1;
        pm = GameObject.FindGameObjectWithTag("pause").GetComponent<PauseMenu>();
        colorr = enemy.GetComponent<Renderer>().material.color;
        enemyHidden = new UnityEngine.Color(colorr.r, colorr.g, colorr.b, 2.5f);
        enemyAttacking = new UnityEngine.Color(colorr.r, colorr.g, colorr.b, 30f);
    }

    void Update()
    {
        if (starttimer == true && pm.GameIsPaused == false)
        {
            timer += Time.deltaTime;
        }


        if (timer > 1)
        {
            rb.velocity = Vector2.zero;
            starttimer = false;
            timer = 0;
        }

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        Vector2 backdirection = startPosition - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float backangle = Mathf.Atan2(backdirection.y, backdirection.x) * Mathf.Rad2Deg;
        if (mv.die != true && distance < ndistance && starttimer == false && pm.GameIsPaused == false && ShootRaycast(layermask,distancee))
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            enemySprite.GetComponent<Renderer>().material.color = enemyAttacking;
        }
        else if (mv.die != true && starttimer == false && pm.GameIsPaused == false)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, startPosition, speed * Time.deltaTime * 0.5f);
            transform.rotation = Quaternion.Euler(Vector3.forward * backangle);
            enemySprite.GetComponent<Renderer>().material.color = enemyHidden;
        }
        square.transform.localScale = new Vector2(ndistance * 1.4f, ndistance * 1.4f);

        if (healther == 1)
        {
            H1.SetActive(true);
        }
        if (healther == 0)
        {
            enemy.SetActive(false);
        }

        if (startTimer2 == true)
        {
            timer2 += Time.deltaTime;
        }
        if (timer2 > 0.5f)
        {
            startTimer2 = false;
            timer2 = 0;
        }

        if (pm.GameIsPaused == true)
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checks the objects tag , if the tag isnt player then it doesnt kill  you bruh
        if (collision.gameObject.tag == ("Plauer") && pm.GameIsPaused == false)
        {
            if (healt.currenthealth > 0 && starttimer == false)
            {
                healt.currenthealth--;
                starttimer = true;
                rb.velocity = new Vector2(-10, -10);
            }

            if (healt.currenthealth == 0)
            {
                mv.die = true;
                mv.rb.velocity = Vector2.zero;
                mv.playtimer = false;
                mv.f = 2;
                mv.e = 2;
                rb.velocity = Vector2.zero;
            }
        }

    }

    public void TakeDamage(int i)
    {
        if (startTimer2 == false && pm.GameIsPaused == false)
        {
            healther = healther - i;
            if (healther == 0)
            {
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + 1);
                enemy.SetActive(false);
            }
            print("damageDealt");
            startTimer2 = true;
        }
    }

    bool ShootRaycast(LayerMask layermask, int distance)
    {

        RaycastHit2D hitInfo;
        hitInfo = Physics2D.Raycast(transform.position, (player.transform.position - enemy.transform.position).normalized, distance, layermask);
        if (hitInfo.collider != null)
        {
            Debug.DrawRay(transform.position, hitInfo.transform.position - transform.position, UnityEngine.Color.green, Time.deltaTime, false);
            if (hitInfo.collider.gameObject.tag == "Plauer")
            {
                print("raycast hit player");
                return true;
            }
            else
            {
                print("raycast hit " + hitInfo.collider.gameObject.name);
                return false;
            }
        }
        Debug.DrawRay(transform.position, player.transform.position - transform.position * distance, UnityEngine.Color.red, Time.deltaTime, false);
        print("raycast hit nothing");
        return false;
    }
}
