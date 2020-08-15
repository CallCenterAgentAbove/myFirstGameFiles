using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        
    }
    //public void playFrog()
    //{
      //  SceneManager.MoveGameObjectToScene
    //}

    public void quitGame()
    {
        Debug.Log("Out of the Game");
        Application.Quit();
    }
}
