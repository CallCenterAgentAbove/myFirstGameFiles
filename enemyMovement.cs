using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] public float xMovement, yVel, toJump, movingForward, movingBackward;
    public Rigidbody2D movingCharacter;
    public leftCheckMove leftCheckMove;
    public rightCheckMove rightCheckMove;
    public walkingOnMovingSuface walkingOnMovingSuface;
    Vector3 movingLeft;
    Vector3 movingRight;



    private void Start()
    {
        //rightCheckMove.obstacleFront = true;
        //leftCheckMove.obstacleBack = true;

        //movingForward = xMovement;
        //movingBackward = -xMovement;

        toJump = 0;
        //movingLeft  = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);
        //movingRight = new Vector3(transform.position.x + xMovement * Time.deltaTime, transform.position.y, transform.position.z);
    }
    void Update()
    {
        Vector3 fixedVelocity = movingCharacter.velocity;
        fixedVelocity.x *= 0.7f;

        if (toJump > 9)
        {
            //movingCharacter.transform.position = new Vector2(movingCharacter.transform.position.x, movingCharacter.transform.position.y + 1);

            movingCharacter.velocity = new Vector2(0, yVel);

            toJump = 0;
        }

        movingCharacter.transform.position = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);
        //movingCharacter.transform.position = movingLeft;

        if (rightCheckMove.obstacleFront)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = false;
            xMovement = movingBackward;
            movingCharacter.transform.position = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);
            toJump++;


            //leftCheckMove.obstacleBack = false;
            //xMovement = 0.2f;
            //xMovement = +xMovement;
            //movingCharacter.transform.position = movingRight;
        }

        if (leftCheckMove.obstacleBack)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = true;
            xMovement = movingForward;
            movingCharacter.transform.position = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);
            toJump++;
            //movingCharacter.transform.position = movingLeft;
            //rightCheckMove.obstacleFront = false;
            //xMovement = -0.2f;
            //xMovement = -xMovement;

        }

        //this was for the enemy not to slide when touching the circle collider of the character, this did not work thou
        //if (walkingOnMovingSuface.onGround)
        //{
        //    movingCharacter.velocity = fixedVelocity;

        //}

    }
    //para que el personaje salte sobre los enemigos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("killer"))
        {
            movingCharacter.GetComponent<Animator>().SetBool("killed", true);
            movingCharacter.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 0.15f);

        }
    }

}
