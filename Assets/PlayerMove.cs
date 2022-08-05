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
    Vector2 moveBackward;
    public int maxrota;
    //public int maxspeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float slow = Input.GetAxis("Slowdown");
        move = transform.up * v;
        //moveBackward = transform.up * slow;
        rotate = -h;
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed;
        /*if (rb.velocity <= )
        {
            rb.velocity = moveBackward;
        }*/
        rb.angularVelocity = rotate * rspeed;
        if (rb.angularVelocity > maxrota)
        {
            rb.angularVelocity = maxrota;
        }
        if (rb.angularVelocity < -maxrota)
        {
            rb.angularVelocity = -maxrota;
        }
    }
}
