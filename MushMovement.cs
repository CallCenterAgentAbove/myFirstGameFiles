using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushMovement : MonoBehaviour
{
    //public scriptable data;
    public float xMovement = 0.2f;
    public GameObject movingCharacter;
    public leftCheckMove leftCheckMove;
    public rightCheckMove rightCheckMove;
    //public GameObject pissedSound;
    //public killingEnemy killingEnemy;
    public bool killedPissed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x - xMovement * Time.deltaTime, transform.position.y, transform.position.z);
        //.AddForce(0, 0, );

        if (rightCheckMove.obstacleFront)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = false;
            xMovement = 0.2f;
            //leftCheckMove.obstacleBack = false;
        }

        if (leftCheckMove.obstacleBack)
        {
            movingCharacter.GetComponent<SpriteRenderer>().flipX = true;
            xMovement = -0.2f;
            //rightCheckMove.obstacleFront = false;
        }

        
    }

    //para que el personaje salte sobre los enemigos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("floorchecker"))
        {
            //killedPissed = true;
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
