using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlessGameManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverScreen;

    void Start()
    {

        gameOver = false;
        gameOverScreen.SetActive(false);
        
    }

    void Update()
    {

        if (gameOver)
            gameOverScreen.SetActive(true);
        
    }

    public void restart()
    {

        SceneManager.LoadScene("Endless");
        gameOver = false;
        Score.score = 0;

    }

    public void back2menu ()
    {

        SceneManager.LoadScene("UI");

    }
}
