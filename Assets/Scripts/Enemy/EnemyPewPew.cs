using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPewPew : MonoBehaviour
{

    public float timeBetweenShots;
    public float nextShot = -1;
    public GameObject bullet;
 
    void Start()
    {

        nextShot = Time.time + Random.Range(1, 3.0f);
        timeBetweenShots = Random.Range(3, 6.5f);

    }
    
    void Update()
    {

        if(Time.time > nextShot)
        {

            if (gameObject.tag == "Enemy") 
                Instantiate(bullet, transform.position, Quaternion.identity);

            else if (gameObject.tag == "enhancedEnemy")
            {

                Instantiate(bullet, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(bullet, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Quaternion.identity);

            }

            else
            {

                Instantiate(bullet, transform.position, Quaternion.identity);
                Instantiate(bullet, new Vector3(transform.position.x + 2, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(bullet, new Vector3(transform.position.x - 2, transform.position.y, transform.position.z), Quaternion.identity);

            }

            nextShot = Time.time + timeBetweenShots;

        }
        
    }
}
