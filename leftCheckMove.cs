using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

public class leftCheckMove : MonoBehaviour
{
    public bool obstacleBack;
    public gameControler gameControler;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface") || collision.CompareTag("enemy"))
        {
            obstacleBack = true;
            //xMovement = xMovement;

        }

        //if (collision.CompareTag("Player"))
        //{
        //   gameControler.vidas = gameControler.vidas - 1;
        //}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface") || collision.CompareTag("enemy"))
        {
            obstacleBack = false;

        }
    }
}
