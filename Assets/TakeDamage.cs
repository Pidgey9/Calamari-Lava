using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public VarByte hp;
    bool invincible;
    float count;
    public float invTimer;
    public float spriteTimer;
    public int disp;
    private void Awake()
    {
        hp.value = 3;
        invincible = false;
        count = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Level"))
        {
            if (!invincible) hp.value--;
            invincible = true;
        }
    }
    private void Update()
    {
        if (hp.value == 0)
        {
            Destroy(gameObject);
            GameObject.Find("Game Over").GetComponent<TextMeshProUGUI>().enabled = true;
        }
        if (invincible)
        {
            count += Time.deltaTime;
            disp = ((int)(count * 10));
            if (disp % spriteTimer == 0) GameObject.Find("Capsule").GetComponent<SpriteRenderer>().enabled = true;
            else GameObject.Find("Capsule").GetComponent<SpriteRenderer>().enabled = false;

        }
        if (count > invTimer)
        {
            GameObject.Find("Capsule").GetComponent<SpriteRenderer>().enabled = true;
            invincible = false;
            count = 0;
        }
    }
}
