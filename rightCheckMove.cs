using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCheckMove : MonoBehaviour
{
    public bool obstacleFront;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface") || collision.CompareTag("enemy"))
        {
            obstacleFront = true;
            //xMovement = -xMovement;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface") || collision.CompareTag("enemy"))
        {
            obstacleFront = false;

        }
    }
}
