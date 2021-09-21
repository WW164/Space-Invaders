using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int speed = 2;

    private Rigidbody2D RB2D;

    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
        RB2D.velocity = new Vector2(speed, 0);
        
    }

    void Update()
    {

        if (transform.position.x >= 10)
        {

            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 1);
            speed = -speed;

            RB2D.velocity = new Vector2(speed, 0);

        }

        else if (transform.position.x <= -10)
        {

            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1);
            speed = -speed;

            RB2D.velocity = new Vector2(speed, 0);

        }

        else if (transform.position.y < -4)
            gameManager.gameOver = true;
              
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            Destroy(collision.gameObject);
            gameManager.playerDead();
            endlessGameManager.gameOver = true;

        }

        else if (collision.tag == "Bunker")  
            Destroy(collision.gameObject);
            

    }
}
