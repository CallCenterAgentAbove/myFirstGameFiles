using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSensor : MonoBehaviour
{
    public fruitCounter fruitCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fruit"))
        {
            fruitCounter.fruits = fruitCounter.fruits += 1;
        }
    }
}
