using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public GameObject player;
    private float timer;
    public movementAndDeath mv;
    public Rigidbody2D rb;
    public float speed;
    public GameObject square;
    public GameObject square2;
    public GameObject square3;
    public GameObject enemy;
    public bool hitonce;
    public PauseMenu pm;
    public Vector3 startPosition;
    public float ndistance;
    public float n2distance;
    public float n3distance;
    public GameObject back;
    public GameObject front;
    public float speeder;
    public GameObject ArrowSprite;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("Plauer");
        mv = GameObject.FindGameObjectWithTag("Plauer").GetComponent<movementAndDeath>();
        pm = GameObject.FindGameObjectWithTag("pause").GetComponent<PauseMenu>();
        ndistance = 32;
        n2distance = 28;
        n3distance = 18;
        speeder = 3;
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(bulletPos.position, player.transform.position);
        if (distance > 24)
        {
            timer = 1.9f;
            ArrowSprite.SetActive(true);
        }
        if (distance < 24)
        {
            if (timer > 1.5f)
            {
                ArrowSprite.SetActive(true);
            }
            timer += Time.deltaTime;
            if (timer > 2.5f)
            {
                timer = 0;
                shoot();
                ArrowSprite.SetActive(false);
            }
        }

        Vector2 direction = player.transform.position - transform.position;
        Vector2 backdirection = startPosition - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float runangle = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        float backangle = Mathf.Atan2(backdirection.y, backdirection.x) * Mathf.Rad2Deg;
        if (mv.die != true && distance < 24 && distance > 20 && pm.GameIsPaused == false)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else if (mv.die != true && distance < 20 && distance > 14 && pm.GameIsPaused == false)
        {
            //Debug.Log("hesStandingThere...MENECINGLY");
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else if (mv.die != true && distance < 14 && pm.GameIsPaused == false)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, back.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        else if (mv.die != true && pm.GameIsPaused == false)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, startPosition, speed * Time.deltaTime * 0.5f);
            transform.rotation = Quaternion.Euler(Vector3.forward * backangle);
        }
        square.transform.localScale = new Vector2(ndistance, ndistance);
        square2.transform.localScale = new Vector2(n2distance, n2distance);
        square3.transform.localScale = new Vector2(n3distance, n3distance);



        if (pm.GameIsPaused == true)
        {
            rb.velocity = Vector2.zero;
        }
    }



    public void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Plauer") && pm.GameIsPaused == false)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + 1);
            enemy.SetActive(false);
        }
    }
}
