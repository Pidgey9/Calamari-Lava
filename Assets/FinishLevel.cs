using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public Transform[] Spawn;
    public int increment;
    public VarFloat timer;
    bool stopTime;
    public VarByte hp;
    private void Awake()
    {
        increment = 0;
        timer.value = 0;
        stopTime = false;
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
                increment++;
            }
        }
    }
    private void Update()
    {
        if (!stopTime) timer.value += Time.deltaTime;
    }
}
