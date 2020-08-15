using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneDetector : MonoBehaviour
{
    public GameObject Player;
    private float distanceToActivate;


    void Update()
    {
        distanceToActivate = Vector2.Distance(Player.transform.position, gameObject.transform.position);

        if (distanceToActivate <= 0.3f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}

