using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 move;
    public float speed;
    float h;
    float v;
    public float angle;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        move = transform.up * v * speed * Time.fixedDeltaTime;
    }
    void FixedUpdate()
    {
        rb.velocity = move * speed * Time.fixedDeltaTime;
        rb.angularVelocity = h * angle * Time.fixedDeltaTime;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            byte i = 0;
            if (i > 100) Destroy(gameObject);
            i++;
        }
    }
}
