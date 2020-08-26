using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] public float xMovement, yVel, toJump;
    public Rigidbody2D movingCharacter;
    public leftCheckMove leftCheckMove;
    public rightCheckMove rightCheckMove;


    private void Start()
    {
        toJump = 0;
    }
    void Update()
    {
        if (toJump > 9)
        {
            //movingCharacter.transform.position = new Vector2(movingCharacter.transform.position.x, movingCharacter.transform.position.y + 1);

            movingCharacter.velocity = new Vector2(0, yVel);

            toJump = 0;
        }

        transform.position = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);

        if (rightCheckMove.obstacleFront)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = false;
            xMovement = 0.2f;
            toJump++;

        }

        if (leftCheckMove.obstacleBack)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = true;
            xMovement = -0.2f;
            toJump++;

        }


    }

    //para que el personaje salte sobre los enemigos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("floorchecker"))
        {
            movingCharacter.GetComponent<Animator>().SetBool("killed", true);
            movingCharacter.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 0.15f);

        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("floorchecker"))
    //    {
    //        //Untagged because if not, the frog jumps infinitely if killing the enemy is in a tight place, like right under a platform
    //        killedPissed = false;
    //        movingCharacter.GetComponent<Rigidbody2D>().tag = "Untagged";

    //    }

    //}
}
