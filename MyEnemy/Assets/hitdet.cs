using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Assertions.Must;

public class hitdet : MonoBehaviour
{    // Start is called before the first frame update
    public bool timerStatus;
    public swordScript ss;
    public swordMelee ss2;
    public bool cantAttackTwiceBozo;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == ("Enemy") && ss.swordWasCollected == true && cantAttackTwiceBozo == false && ss2.duringattack == true)
        {
            collision.gameObject.GetComponent<AI>().TakeDamage(1);
            cantAttackTwiceBozo = true;
            print("hitEnemy");
        }
        else if (collision.gameObject.tag == ("GuardEnemy") && ss.swordWasCollected == true && cantAttackTwiceBozo == false && ss2.duringattack == true)
        {
            collision.gameObject.GetComponent<guardai>().TakeDamage(1);
            cantAttackTwiceBozo = true;
            print("hitEnemy");
        }
        else if (collision.gameObject.tag == ("ShooterEnemy") && ss.swordWasCollected == true && cantAttackTwiceBozo == false && ss2.duringattack == true)
        {
            collision.gameObject.SetActive(false);
            cantAttackTwiceBozo = true;
            print("hitEnemy");
        }
        else if (collision.gameObject.tag == ("FastEnemy") && ss.swordWasCollected == true && cantAttackTwiceBozo == false && ss2.duringattack == true)
        {
            collision.gameObject.SetActive(false);
            cantAttackTwiceBozo = true;
            print("hitEnemy");
        }
    }
}
