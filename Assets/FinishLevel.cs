using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public Transform[] Spawn;
    public int increment;
    public VarByte hp;
    public GameObject[] lava;
    private void Awake()
    {
        increment = 0;
    }
    private void Start()
    {
        lava[increment].GetComponent<LavaMove>().enabled = true;
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
                hp.value = 3;
                // To avoid bugs
                GetComponent<TakeDamage>().invincible = false;
                GetComponent<TakeDamage>().stuck = 0;
                GameObject.Find("Capsule").GetComponent<SpriteRenderer>().enabled = true;
                increment++;
                lava[increment].GetComponent<LavaMove>().enabled = true;
                Destroy(lava[increment - 1]);
            }
        }
    }
}
