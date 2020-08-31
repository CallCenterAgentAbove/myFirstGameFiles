using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCounter : MonoBehaviour
{
    public gameControler gameControler;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fruit"))
        {
            gameControler.FruitTaken();
        }

        if (collision.CompareTag("coin"))
        {
            gameControler.CoinTaken();
        }

        /*if (collision.CompareTag("rightKilled"))
        {
            gameControler.LessHealth();
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.2f, gameObject.transform.position.y);

        }

        if (collision.CompareTag("leftKilled"))
        {
            gameControler.LessHealth();
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.2f, gameObject.transform.position.y);
        }*/
    }
}
