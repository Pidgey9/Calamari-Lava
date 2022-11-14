using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LavaOver : MonoBehaviour
{
    float count;
    public float timeDispawn;
    bool lavaTouch;
    Rigidbody2D rb;
    private void Awake()
    {
        count = 0;
        lavaTouch = false;
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            lavaTouch = true;
        }
    }
    private void Update()
    {
        if (lavaTouch)
        {
            count += Time.deltaTime;
        }
        if (count > timeDispawn)
        {
            Destroy(gameObject);
            GameObject.Find("Game Over").GetComponent<TextMeshProUGUI>().enabled = true;
        }
        if (lavaTouch)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            GetComponent<Move>().enabled = false;
        }
    }
}
