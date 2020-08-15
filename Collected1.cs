using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected1 : MonoBehaviour
{
    public GameObject collectionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //gameObject.GetComponent<coinCounter>().CoinPlus();
            //GetComponent<DestroyObject>().enabled = true;
            //coinCounter.coins = coinCounter.coins += 1;
            Instantiate(collectionSound);
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = false;
            //Destroy(gameObject, 1f);

        }
    }

    
}
