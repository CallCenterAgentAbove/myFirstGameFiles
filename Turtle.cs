using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    private float distanceToEnemy;
    public GameObject characterToChange;
    //public GameObject Player;
    public gameControler gameControler;
    private float killDistance = 1.5f;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        distanceToEnemy = Vector2.Distance(characterToChange.transform.position, gameControler.Character.transform.position);

        if (distanceToEnemy <= killDistance)
        {
            characterToChange.GetComponent<Animator>().SetBool("frogClose", true);
        }

        else
        {
            characterToChange.GetComponent<Animator>().SetBool("frogClose", false);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        characterToChange.GetComponent<Animator>().SetBool("frogClose", true);
            //character.GetComponent<Animator>().SetBool("frogFar", false);

    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        characterToChange.GetComponent<Animator>().SetBool("frogClose", false);
        //character.GetComponent<Animator>().SetBool("frogFar", true);
    //    }
        
    //}


}
