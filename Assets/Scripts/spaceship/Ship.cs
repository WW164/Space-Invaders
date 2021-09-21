using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public GameObject shot;

    private Rigidbody2D RB2D;

    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        Vector2 shipVelocity = new Vector2(Input.GetAxis("Horizontal") * 10, 0);
        RB2D.velocity = shipVelocity;

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(shot, transform.position, Quaternion.identity);
        
    }
}
