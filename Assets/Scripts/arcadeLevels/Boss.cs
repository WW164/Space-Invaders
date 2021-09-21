using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    void Update()
    {

        if (transform.childCount <= 0)
            gameManager.winGame();
        
    }
}
