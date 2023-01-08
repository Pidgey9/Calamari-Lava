using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public Transform[] Spawn;
    public int increment;
    public VarByte hp;
    public GameObject[] lava;
    public VarByte coinCollector;
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
                GameObject.Find("Restart").GetComponent<TextMeshProUGUI>().enabled = true;
                GameObject.Find("Win").GetComponent<TextMeshProUGUI>().enabled = true;
                if (coinCollector.value >= 30)
                {
                    GameObject.Find("Score").GetComponent<TextMeshProUGUI>().enabled = true;
                    GameObject.Find("Win Timer").GetComponent<TextMeshProUGUI>().enabled = true;
                }
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
