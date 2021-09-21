using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliensLevel1 : MonoBehaviour
{

    void Update()
    {

        if (transform.childCount <= 0 && gameManager.level == 1)
            gameManager.winGame();

    }
}
