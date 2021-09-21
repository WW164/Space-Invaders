using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public static int life = 3;
    public GameObject Lives;

    void Start()
    {

        for (int i = 1; i <= life; i++)
            Instantiate(Lives, new Vector3 (transform.position.x + i, transform.position.y, transform.position.z), Quaternion.identity);

    }

    public static void loseLife()
    {

        life --;

    }

    private void LateUpdate()
    {

        if (life <= 0)
            gameManager.gameOver = true;
      
    }
}
