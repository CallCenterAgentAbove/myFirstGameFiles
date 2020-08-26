using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePath : MonoBehaviour
{
    public gameControler gameControler;
    private float distanceToPlayer;
    public Transform position1;
    Vector3 initialPos;

    void Start()
    {
        gameObject.GetComponent<AIPath>().enabled = false;
        //gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

        initialPos = position1.transform.position;

    }

    private void Update()
    {
        distanceToPlayer = Vector2.Distance(gameObject.transform.position, gameControler.Character.transform.position);

        if (distanceToPlayer <= 3.7)
        {
            gameObject.GetComponent<AIPath>().enabled = true;
            //gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1f, -1f, 1f);
            gameObject.transform.localScale = new Vector3(1f, -1f, 1f);


        }

        else
        {
            gameObject.GetComponent<AIPath>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            //gameObject.transform.GetChild(0).gameObject.transform.position = initialPos;
            gameObject.transform.position = initialPos;

        }
    }

}
