using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FrogMovement : MonoBehaviour
{
    public Rigidbody2D Frog;
    public float xmovement;
    public float yVel;
    public bool frogmode;
    public GameObject jumpsound;
    public TextMeshProUGUI deadText;
    public FloorChecker floorChecker;
    //public coinCounter coinCounter;
    public gameControler gameControler;

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            Frog.GetComponent<SpriteRenderer>().flipX = true;
            Frog.transform.position = new Vector2(Frog.transform.position.x + -xmovement * Time.deltaTime, Frog.transform.position.y);
            Frog.GetComponent<Animator>().SetBool("Run", true);
            Frog.GetComponent<Animator>().SetBool("idle", false);

            if (!floorChecker.OnGround)
            {
                Frog.GetComponent<Animator>().SetBool("Run", false);
                //Frog.GetComponent<Animator>().SetBool("onTheAir", true);
            }
        }

        else if (Input.GetKey("d"))
        {
            Frog.GetComponent<SpriteRenderer>().flipX = false;
            Frog.transform.position = new Vector2(Frog.transform.position.x + xmovement * Time.deltaTime, Frog.transform.position.y);
            Frog.GetComponent<Animator>().SetBool("Run", true);
            Frog.GetComponent<Animator>().SetBool("idle", false);

            if (!floorChecker.OnGround)
            {
                Frog.GetComponent<Animator>().SetBool("Run", false);
                //Frog.GetComponent<Animator>().SetBool("onTheAir", true);
            }
        }


        else
        {
            //Frog.transform.position = new Vector2(Frog.transform.position.x + 0, Frog.transform.position.y + 0);
            Frog.GetComponent<Animator>().SetBool("idle", true);
            Frog.GetComponent<Animator>().SetBool("Run", false);
        }

        if (Input.GetKey("w") && floorChecker.OnGround || frogmode && floorChecker.OnGround) // || !floorChecker.OnGround && floorChecker.killed
        {
            Frog.velocity = new Vector2(0, yVel);
            //Frog.GetComponent<AudioSource>().enabled = true; 
            Instantiate(jumpsound);
            Frog.GetComponent<Animator>().SetBool("onTheAir", true);
        }

        if (floorChecker.OnGround)
        {
            Frog.GetComponent<Animator>().SetBool("idle", true);
            Frog.GetComponent<Animator>().SetBool("onTheAir", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Killed"))
        {
            gameControler.health = gameControler.health -= 1;
            Frog.transform.position = new Vector2(Frog.transform.position.x - 0.2f, Frog.transform.position.y);

        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Killed"))
        {
            //floorChecker.OnGround = false;

        }

    }

    
}
