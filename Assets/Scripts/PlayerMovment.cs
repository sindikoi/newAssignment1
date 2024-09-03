using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] Rigidbody2D rb;
    private float x;
    private float y;
    private Vector2 movement;
    private bool onGround=true;
    [SerializeField] float jumpForce = 8f;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
            Debug.LogError(" RigitBody is missing");
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

         movement = new Vector2(x, y);

       

    }

 
    private void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }

    
}
