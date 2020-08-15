using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject collectionSound;

    private void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
               
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Instantiate(collectionSound);
            Destroy(gameObject, 0.5f);

        }
    }

}