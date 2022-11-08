using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public VarByte coin;
    private void Awake()
    {
        coin.value = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coin.value++;
            Destroy(collision.gameObject);
        }
    }
}
