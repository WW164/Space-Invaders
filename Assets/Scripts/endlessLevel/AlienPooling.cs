using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienPooling : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject enhancedEnemy;
    public GameObject Boss;
    public float spawnRate = 1f;

    private Vector2 objectPoolPosition = new Vector2(-10f, 6f);
    private float timeSinceLastSpaened;
    private int randEnemy;

    void Update()
    {

        timeSinceLastSpaened += Time.deltaTime;
        if(endlessGameManager.gameOver ==  false && timeSinceLastSpaened >= spawnRate)
        {

            timeSinceLastSpaened = 0;

            randEnemy = Random.Range(1, 6);

            if (randEnemy == 1 || randEnemy == 3 || randEnemy == 5)
                Instantiate(Enemy, objectPoolPosition, Quaternion.identity);

            else if (randEnemy == 2 || randEnemy == 4)
                Instantiate(enhancedEnemy, objectPoolPosition, Quaternion.identity);

            else if (randEnemy == 6)
                Instantiate(Boss, objectPoolPosition, Quaternion.identity);
        }

    }
}
