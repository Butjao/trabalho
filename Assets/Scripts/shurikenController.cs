using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikenController : MonoBehaviour
{
    public GameObject Player;

    public float speed = 20f;
    public Rigidbody2D rb;
    public float FacingRight;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(Player.GetComponent<playerController>().facingRight);
        FacingRight = Player.GetComponent<playerController>().facingRight;
       
        rb.velocity = transform.right * speed *FacingRight;
       
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
    }
}
