using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public Transform[] Spawn;
    public int increment;
    private void Awake()
    {
        increment = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            if (increment >= Spawn.Length)
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = Spawn[increment].position;
                increment++;
            }
        }
    }
}
