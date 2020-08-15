using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tilemap2surface : MonoBehaviour
{
    public bool closeSurface;
    public Rigidbody2D Tilemap;
    public Rigidbody2D player
        ;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("upperSurface"))
        {
            closeSurface = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("upperSurface")) 
        {
            closeSurface = false;
        }
    }

    private void Update()
    {

        if (closeSurface)
        {
            Tilemap.GetComponent<CompositeCollider2D>().isTrigger = true;
        }
        else if (!closeSurface)
        {
            Tilemap.GetComponent<CompositeCollider2D>().isTrigger = false;
        }

    }
}
