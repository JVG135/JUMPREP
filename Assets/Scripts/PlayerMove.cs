using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool midair = false;
    
    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && midair == false)
        {midair = true;
            rb.velocity = new Vector2(rb.velocity.x, 8f);}
    }
    private void OnCollisionEnter2D(Collision2D c) {midair = false;}
}
