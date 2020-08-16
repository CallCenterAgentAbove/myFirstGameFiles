using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabezonDistance : MonoBehaviour
{
    public GameObject Player;
    public float distanceToPlayer;
    private float distanceToActivate;


    void Update()
    {
        distanceToActivate = Vector2.Distance(Player.transform.position, gameObject.transform.position);

        if (distanceToActivate <= distanceToPlayer)
        {
           gameObject.GetComponent<Animator>().enabled = true;
        }

        if (distanceToActivate >= distanceToPlayer)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
