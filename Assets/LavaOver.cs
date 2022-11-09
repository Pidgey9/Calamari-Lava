using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LavaOver : MonoBehaviour
{
    float count;
    public float timeDispawn;
    bool lavaTouch;
    private void Awake()
    {
        count = 0;
        lavaTouch = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            lavaTouch = true;
            GameObject.Find("Player").GetComponent<Move>().enabled = false;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = Vector2.zero;
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
    }
}
