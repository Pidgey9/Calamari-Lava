using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpCollider : MonoBehaviour
{
    public Vector2 data;
    public Vector2 push;
    Rigidbody2D rb;
    public float force;
    ContactPoint2D[] contactPoints;
    public AnimationCurve bumpCurve;
    float bumpTimer;
    public float bumpDuration;
    public Vector2 question;
    public bool bam;
    bool zero;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bam = false;
        zero = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Level"))
        {
            contactPoints = collision.contacts;
            Vector3 impact = contactPoints[0].point;
            data = transform.position - impact;
            push = data.normalized;
            bam = true;
            zero = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Level"))
        {
            zero = false;
        }
    }
    private void FixedUpdate()
    {
        if (bam)
        {
            BumpScript(push);
            rb.AddForce(question * force);
        }
    }
    void BumpScript(Vector2 push)
    {
        if (bumpTimer < bumpDuration)
        {
            bumpTimer += Time.deltaTime;
            if (zero) bumpTimer = 0;
            float z = bumpCurve.Evaluate(bumpTimer / bumpDuration);
            question = push * z;
        }
        else
        {
            bumpTimer = 0;
            bam = false;
        }
    }
}
