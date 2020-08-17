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
    //public coinCounter coinCounter;
    public gameControler gameControler;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Killed"))
        {
            gameControler.health = gameControler.health -= 1;
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.2f, gameObject.transform.position.y);

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
