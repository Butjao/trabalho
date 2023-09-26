using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UIElements;

public class playerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    private Rigidbody2D rb;
    public int facingRight = 1;
    public GameObject sprite;
    public GameObject shuriken;
    public GameObject spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x, jumpHeight);
        }


        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log('d');
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (facingRight < 0) {
                flipPlayer();
            }
           
        } 

        if (Input.GetKey(KeyCode.A))
        {
           
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1* moveSpeed, rb.velocity.y);
            if (facingRight > 0)
            {
                flipPlayer();
            }
        }

        if (Input.GetKeyDown (KeyCode.F)) 
        {
            Debug.Log('a');
            Instantiate(shuriken, spawnPosition.transform.position, Quaternion.identity);
        }
    }

    public void flipPlayer()
    {
        facingRight *= -1;
        transform.Rotate(0f, 180f, 0f);
       // sprite.transform.localScale = new Vector3(facingRight, 1, 1);
    }
}
