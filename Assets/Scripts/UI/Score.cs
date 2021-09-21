using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int score;
    public Text scoreText;

    public static void updateScore ()
    {
        score++;

    }

    private void LateUpdate()
    {

        scoreText.text = "Score: " + score;

    }
}
