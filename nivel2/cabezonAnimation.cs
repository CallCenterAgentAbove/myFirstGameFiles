using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabezonAnimation : MonoBehaviour
{
    //public GameObject Player;
    //private float distanceToActivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<Animator>().enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
    void Update()
    {
        //distanceToActivate = Vector2.Distance(Player.transform.position, gameObject.transform.position);

        //if (distanceToActivate <= 2f)
        //{
        //   gameObject.GetComponent<Animator>().enabled = true;
        //}
    }
}
