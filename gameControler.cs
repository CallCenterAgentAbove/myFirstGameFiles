using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameControler : MonoBehaviour
{
    public GameObject heart1, heart2;
    public TextMeshProUGUI deadText;
    public int health;
    public GameObject Frog;
    public GameObject pedoSound;



    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        heart1.GetComponent<Animator>().enabled = false;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        deadText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 4)
            health = 4;

        switch (health)
        {

            case 4:
                heart1.GetComponent<SpriteRenderer>().enabled = true;
                heart1.GetComponent<Animator>().enabled = false;
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                deadText.gameObject.SetActive(false);
                break;
            case 2:
                heart1.GetComponent<Animator>().enabled = true;
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                deadText.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                Frog.GetComponent<Animator>().SetBool("hit", true);
                deadText.gameObject.SetActive(true);
                Invoke("ResetScene", 1.2f);
                break;
        }

        if (health == 0)
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
    }

    private void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
