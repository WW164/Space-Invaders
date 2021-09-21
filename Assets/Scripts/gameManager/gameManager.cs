using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public static int level = 1;

    public static bool isPlayerDead;
    public static bool gameOver;
    static bool hasWon;
    public GameObject loseScreen;
    public GameObject winScreen;
    public GameObject gameoverScreen;

    void Start()
    {

        isPlayerDead = false;
        gameOver = false;
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
        gameoverScreen.SetActive(false);

    }

    void Update()
    {
        if (isPlayerDead)
            loseScreen.SetActive(true);

        else if (hasWon)
            winScreen.SetActive(true);

        else if (gameOver)
        {

            gameoverScreen.SetActive(true);
            loseScreen.SetActive(false);

        }

    }
    public static void playerDead ()
    {

        isPlayerDead = true;
        Life.loseLife();

    }

    public void restart()
    {

        if (level == 1)
            SceneManager.LoadScene("arcadeLevel1");

        else if (level == 2)
            SceneManager.LoadScene("arcadeLevel2");

        else if (level == 3)
            SceneManager.LoadScene("arcadelevel3");

    }

    public void back2Menu()
    {

        SceneManager.LoadScene("UI");
        UIManager.restartedLevel = true;

    }

    public void nextLevel ()
    {

        if (level == 1)
        {

            hasWon = false;
            winScreen.SetActive(false);
            SceneManager.LoadScene("arcadeLevel2");
            level++;

        }

        else if (level == 2)
        {

            hasWon = false;
            winScreen.SetActive(false);
            SceneManager.LoadScene("arcadeLevel3");
            level++;

        }

        else if (level == 3)
            SceneManager.LoadScene("Ending");
        
    }

    public static void winGame ()
    {

        hasWon = true;

    }
}
