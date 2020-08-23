using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class gameControler : MonoBehaviour
{
    public Rigidbody2D Character;
    [SerializeField] private GameObject heart1, heart2, golden1, golden2, golden3, pedoSound, jumpsound, tile2Level, tile3Level, coinSound;
    public int yVel, coins, fruits;
    [SerializeField] private float health, goldenTaken;
    public float xmovement;
    public TextMeshProUGUI deadText, fruitText, coinsText;
    public FloorChecker floorChecker;
    public bool jumpingMode;
    
    void Start()
    {
        health = 4;
        heart1.GetComponent<Animator>().enabled = false;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        deadText.gameObject.SetActive(false);

        goldenTaken = 0;
        //1, 1, 1, 0.5f although we are modifying a 0-255 color range, the only way the script can make changes in sprite colors is from 0-1, just do the math
        golden1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
        golden2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
        golden3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);

        //second level tilemap should be false at the very beginning
        tile2Level.GetComponent<Rigidbody2D>().tag = "Untagged";
        tile2Level.GetComponent<CompositeCollider2D>().isTrigger = true;
        tile2Level.GetComponent<TilemapCollider2D>().enabled = false;

        tile3Level.GetComponent<Rigidbody2D>().tag = "Untagged";
        tile3Level.GetComponent<CompositeCollider2D>().isTrigger = true;
        tile3Level.GetComponent<TilemapCollider2D>().enabled = false;





    }

    // Update is called once per frame
    void Update()
    {
        //for coins counter text
        coinsText.text = "Coins  " + coins.ToString() + "/100";
        //for fuit counter text
        fruitText.text = "Fruits " + fruits.ToString() + "/50";


        //this little part limits health from reaching 5
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
                Character.GetComponent<Animator>().SetBool("hit", true);
                deadText.gameObject.SetActive(true);
                //Instantiate(pedoSound) 
                Invoke("ResetScene", 1.2f);
                break;
        }

        if (health == 0)
        {
            //getcomponent instad of instantiate, inst makes pedoSound sound many times at the same time
            gameObject.GetComponent<AudioSource>().enabled = true;
        }

        if (goldenTaken > 3)
            goldenTaken = 3;

        switch (goldenTaken)
        {
            case 0:
                golden1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                golden2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                golden3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                break;

            case 1:
                golden1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                golden2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                golden3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                break;

            case 2:
                golden1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                golden2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                golden3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
                break;

            case 3:
                golden1.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                golden2.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                golden3.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                break;
        }

        if (Character.transform.position.y >= 0.05f)
        {
            tile2Level.GetComponent<TilemapCollider2D>().enabled = true;
            tile2Level.GetComponent<CompositeCollider2D>().isTrigger = false;
            Invoke("TileTagLevel2", 0.1f);

            if (Character.transform.position.y >= 0.813)
            {
                tile3Level.GetComponent<TilemapCollider2D>().enabled = true;
                tile3Level.GetComponent<CompositeCollider2D>().isTrigger = false;
                Invoke("TileTagLevel3", 0.1f);
            }

            else
            {
                tile3Level.GetComponent<CompositeCollider2D>().isTrigger = true;
                tile3Level.GetComponent<TilemapCollider2D>().enabled = false;
                tile3Level.GetComponent<Rigidbody2D>().tag = "Untagged";
            }

        }

        else
        {
            tile2Level.GetComponent<CompositeCollider2D>().isTrigger = true;
            tile2Level.GetComponent<TilemapCollider2D>().enabled = false;
            tile2Level.GetComponent<Rigidbody2D>().tag = "Untagged";


        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            Character.GetComponent<SpriteRenderer>().flipX = true;
            Character.transform.position = new Vector2(Character.transform.position.x + -xmovement * Time.deltaTime, Character.transform.position.y);
            Character.GetComponent<Animator>().SetBool("Run", true);
            Character.GetComponent<Animator>().SetBool("idle", false);

            if (!floorChecker.OnGround)
            {
                Character.GetComponent<Animator>().SetBool("Run", false);
                //Frog.GetComponent<Animator>().SetBool("onTheAir", true);
            }
        }

        else if (Input.GetKey("d"))
        {
            Character.GetComponent<SpriteRenderer>().flipX = false;
            Character.transform.position = new Vector2(Character.transform.position.x + xmovement * Time.deltaTime, Character.transform.position.y);
            Character.GetComponent<Animator>().SetBool("Run", true);
            Character.GetComponent<Animator>().SetBool("idle", false);

            if (!floorChecker.OnGround)
            {
                Character.GetComponent<Animator>().SetBool("Run", false);
                //Frog.GetComponent<Animator>().SetBool("onTheAir", true);
            }
        }


        else
        {
            //Frog.transform.position = new Vector2(Frog.transform.position.x + 0, Frog.transform.position.y + 0);
            Character.GetComponent<Animator>().SetBool("idle", true);
            Character.GetComponent<Animator>().SetBool("Run", false);
        }

        if (Input.GetKey("w") && floorChecker.OnGround || jumpingMode && floorChecker.OnGround) // || !floorChecker.OnGround && floorChecker.killed
        {
            Character.velocity = new Vector2(0, yVel);
            //Frog.GetComponent<AudioSource>().enabled = true; 
            Instantiate(jumpsound);
            Character.GetComponent<Animator>().SetBool("onTheAir", true);
        }

        if (floorChecker.OnGround)
        {
            Character.GetComponent<Animator>().SetBool("idle", true);
            Character.GetComponent<Animator>().SetBool("onTheAir", false);
        }
    }
    private void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void TileTagLevel2()
    {
        tile2Level.GetComponent<Rigidbody2D>().tag = "jumpSurface";
    }

    private void TileTagLevel3()
    {
        tile3Level.GetComponent<Rigidbody2D>().tag = "jumpSurface";
    }

    public void PlusHealth()
    {
        health += 2;
        Debug.Log("mi salud es 4");
    }

    public void LessHealth()
    {
        health--;
    }

    public void GoldeTaken()
    {
        goldenTaken++;
        //Instantiate(coinSound);
    }

    public void CollectedBoxCollider2D()
    {
        
    }

    public void ScriptPopping()
    {
        
    }

    public void FruitTaken()
    {
        fruits++;
    }

    public void CoinTaken()
    {
        coins++;
    }

}
