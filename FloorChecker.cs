using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class FloorChecker : MonoBehaviour
{
    public bool  OnGround;
    //public bool killed;
    public FrogMovement frogmovement;
    public GameObject jumpSound;
    //public CharacterMovement characterMovement;

    //private void Update()
    //{
    //    killed = false;
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            OnGround = true;

        }

        if (collision.CompareTag("enemy"))
        {
            frogmovement.Frog.velocity = new Vector2(0, frogmovement.yVel);
            Instantiate(jumpSound);
            //killed = true;
        }

       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {
            OnGround = false;

        }

        
        //if (collision.CompareTag("Untagged")) //OLD, commented because i want to try if floorchecker can exits from the enemy when the enemy is still tagged as enemy, instead of tagged as Untagged
        //{
        //    killed = false;
        //}

        
    }
}
