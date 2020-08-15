using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killingEnemy : MonoBehaviour
{
    public bool killedPissed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("floorchecker"))
        {
            killedPissed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("floorchecker"))
        {
            killedPissed = false;
        }

    }
}
