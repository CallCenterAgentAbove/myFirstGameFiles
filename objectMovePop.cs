using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovePop : MonoBehaviour
{
    private float distanceToActivateScript;
    public enemyMovement enemyMovement;
    public gameControler gameControler;


    void Start()
    {
       gameObject.GetComponent<enemyMovement>().enabled = false;
        //gameObject.SetActive(false);

    }

    void Update()
    {

        distanceToActivateScript = Vector2.Distance(enemyMovement.movingCharacter.transform.position, gameControler.Character.transform.position);

        if (distanceToActivateScript < 4)
        {
            gameObject.GetComponent<enemyMovement>().enabled = true;
            //gameObject.SetActive(true);


        }

        else
        {
            gameObject.GetComponent<enemyMovement>().enabled = false;
            //gameObject.SetActive(false);
        }

    }
}
