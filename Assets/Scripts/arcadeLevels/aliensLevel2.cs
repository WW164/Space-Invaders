using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliensLevel2 : MonoBehaviour
{

    void Update()
    {

        if (transform.childCount <= 0 && gameManager.level == 2)
            gameManager.winGame();
        
    }
}
