using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenTaken : MonoBehaviour
{
    public gameControler gameControler;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //gameControler.goldenTaken = gameControler.goldenTaken += 1;
            gameControler.GoldeTaken();
            //gameObject.SetActive(false);

        }
    }
}
