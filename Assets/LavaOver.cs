using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LavaOver : MonoBehaviour
{
    float count;
    public float timeDispawn;
    private void Awake()
    {
        count = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            Debug.Log("Game Over");
        }
    }
    private void Update()
    {
        /*count += Time.deltaTime;
        if (count > timeDispawn)
        {
            Destroy(gameObject);
        }*/
    }
}
