using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    float rotate;
    public float speed;
    public float rspeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        move = transform.up * v;
        rotate = -h;
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed;
        rb.angularVelocity = rotate * rspeed;
    }
}
