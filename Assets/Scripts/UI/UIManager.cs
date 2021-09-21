using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static bool restartedLevel = false;

    public void arcadeLevel()
    {

        if (restartedLevel)
            Life.life = 3;

        SceneManager.LoadScene("Story");

    }

    public void endless()
    {

        SceneManager.LoadScene("Endless");
        Score.score = 0;

    }

    public void credit()
    {

        SceneManager.LoadScene("Credit");

    }

    public void back2Menu()
    {

        SceneManager.LoadScene("UI");

    }

    public void ready()
    {

        SceneManager.LoadScene("arcadeLevel1");

    }

    public void quit ()
    {

        Application.Quit();

    }

}
