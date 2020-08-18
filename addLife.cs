using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addLife : MonoBehaviour
{
    public gameControler gameControler;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //gameControler.health = gameControler.health += 1;
            gameControler.PlusHealth();
            //gameObject.SetActive(false);

        }
    }
}
