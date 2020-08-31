using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private float distanceToPlayer;
    public gameControler gameControler;
    private float distanceToOpen = 0.3f;


    private void Update()
    {
        distanceToPlayer = Vector2.Distance(gameObject.transform.position, gameControler.Character.transform.position);

        if (distanceToPlayer <= distanceToOpen)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            Invoke("StopAnim", 1f);
        }
    }

    void StopAnim()
    {
        gameObject.GetComponent<Animator>().enabled = false;
        gameObject.GetComponent<ChestOpen>().enabled = false;
    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //   {
    //        GetComponent<Animator>().enabled = true;
    ////GetComponent<SpriteRenderer>().sprite = 


    //   }
    //}
}
