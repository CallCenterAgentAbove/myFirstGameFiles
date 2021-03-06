﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingOnMovingSuface : MonoBehaviour
{
    public enemyMovement enemyMovement;
    public bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            enemyMovement.xMovement = 0.2f;
            enemyMovement.movingCharacter.velocity = new Vector2(0, enemyMovement.yVel);
        }

        if (collision.CompareTag("jumpSurface"))
        {
            onGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            enemyMovement.xMovement = enemyMovement.xMovement + 0.1f;

        }

        if (collision.CompareTag("jumpSurface"))
        {
            onGround = false;
        }
    }



}
