using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D Character;
    public float xMovement;
    public float yVelocity;
    public bool jumpingMode;
    public GameObject jumpSound;
    public GameObject walkSound;
    public FloorChecker floorChecker;
    //public MushMovement mushMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            Character.GetComponent<SpriteRenderer>().flipX = true;
            Character.transform.position = new Vector2(Character.transform.position.x + -xMovement * Time.deltaTime, Character.transform.position.y);
            Character.GetComponent<Animator>().SetBool("Run", true);
            Character.GetComponent<Animator>().SetBool("idle", false);
            //Frog.GetComponent<AudioSource>().enabled = false;

            if (!floorChecker.OnGround)
            {
                Character.GetComponent<Animator>().SetBool("Run", false);
                //Frog.GetComponent<Animator>().SetBool("onTheAir", true);
            }

            //gameObject.transform.GetChild(0).gameObject.SetActive(true);
            //Destroy(gameObject, 0.3f);

            //if (Input.GetKey("a") && FloorChecker.OnGround)
            //{
            //    Instantiate(walkSound);
            //}

        }

        else if (Input.GetKey("d"))
        {
            Character.GetComponent<SpriteRenderer>().flipX = false;
            Character.transform.position = new Vector2(Character.transform.position.x + xMovement * Time.deltaTime, Character.transform.position.y);
            Character.GetComponent<Animator>().SetBool("Run", true);
            Character.GetComponent<Animator>().SetBool("idle", false);

            if (!floorChecker.OnGround)
            {
                Character.GetComponent<Animator>().SetBool("Run", false);
                //Character.GetComponent<Animator>().SetBool("onTheAir", true);
            }
            //Frog.GetComponent<AudioSource>().enabled = false;

            //if (Input.GetKey("d") && FloorChecker.OnGround)
            //{
            //    Instantiate(walkSound);
            //}

        }


        else
        {
            Character.GetComponent<Animator>().SetBool("idle", true);
            Character.GetComponent<Animator>().SetBool("Run", false);
        }

        if (Input.GetKey("w") && floorChecker.OnGround || jumpingMode && floorChecker.OnGround) // || floorChecker.killed
        {
            Character.velocity = new Vector2(0, yVelocity);
            //Frog.GetComponent<AudioSource>().enabled = true; 
            Instantiate(jumpSound);
            Character.GetComponent<Animator>().SetBool("onTheAir", true);

            //if (!FloorChecker.OnGround)
            //{
            //    Character.GetComponent<Animator>().SetBool("onTheAir, true");
            //}
        }

        if (floorChecker.OnGround)
        {
            Character.GetComponent<Animator>().SetBool("idle", true);
            Character.GetComponent<Animator>().SetBool("onTheAir", false);
        }

        else if (!floorChecker.OnGround)
         {
             Character.GetComponent<Animator>().SetBool("onTheAir", true);
             Character.GetComponent<Animator>().SetBool("idle", false);
         }


        //if (Tilemap2surface.closeSurface && !FloorChecker.OnGround)
        //{
        //  Frog.GetComponent<BoxCollider2D>().isTrigger = false;
        //}
        //else if (!Tilemap2surface.closeSurface && FloorChecker.OnGround)
        //{
        //    Frog.GetComponent<BoxCollider2D>().isTrigger = true;
        //}

    }
}
