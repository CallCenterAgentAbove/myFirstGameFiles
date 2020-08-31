using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pissingEnemies : MonoBehaviour
{
    public gameControler gameControler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            gameControler.Character.velocity = new Vector2(0, gameControler.yVel);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("jumpSurface"))
        {

        }


    }
}
