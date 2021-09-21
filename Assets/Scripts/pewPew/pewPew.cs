using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewPew : MonoBehaviour
{

    public int speed = 5;
    public string target1;
    public string target2;
    public string target3;
    public GameObject explosion;

    private Rigidbody2D RB2D;

    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
        RB2D.velocity = new Vector2(0, speed);

    }

    void Update()
    {

        if (RB2D.transform.position.y > 4.5)
            Destroy(gameObject);

        else if (RB2D.transform.position.y < -6)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == target1)
        {

            if (collision.tag == "Player")
            {

                gameManager.playerDead();
                endlessGameManager.gameOver = true;

            }

            else
                Score.updateScore();

            Destroy(collision.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.5f);
            Destroy(gameObject);

        }

        else if(collision.tag == target2)
        {

            Destroy(collision.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.5f);
            Destroy(gameObject);

            Score.updateScore();
            Score.updateScore();

        }

        else if (collision.tag == target3)
        {

            Destroy(collision.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.5f);
            Destroy(gameObject);

        }

    }
}
