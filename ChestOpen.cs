using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private float distanceToPlayer;
    public FrogMovement theFrog;
    public GameObject chest;
    private float distanceToOpen = 0.3f;


    private void Update()
    {
        distanceToPlayer = Vector2.Distance(chest.transform.position, theFrog.transform.position);

        if (distanceToPlayer <= distanceToOpen)
        {
            chest.GetComponent<Animator>().enabled = true;
        }
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
