using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSensor : MonoBehaviour
{
    public coinCounter coinCounter;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            coinCounter.coins = coinCounter.coins += 1;
        }
    }
}
