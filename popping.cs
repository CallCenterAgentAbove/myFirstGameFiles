using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popping : MonoBehaviour
{
    private float distanceToPlayer;
    public GameObject characterToPopUp;
    public GameObject Player;
    private float popDistance = 1f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        distanceToPlayer = Vector2.Distance(Player.transform.position, characterToPopUp.transform.position);

        if (distanceToPlayer <= popDistance)
        {
            characterToPopUp.gameObject.SetActive(true);
            //characterToPopUp.GetComponent<SpriteRenderer>().enabled = true;

        }

        if (distanceToPlayer >= popDistance)
        {
            characterToPopUp.gameObject.SetActive(false);
            //characterToPopUp.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}
