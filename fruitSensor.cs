﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSensor : MonoBehaviour
{
    public gameControler gameControler;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fruit"))
        {
            gameControler.fruits++;
        }
    }
}
