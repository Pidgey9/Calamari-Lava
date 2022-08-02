using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaUp : MonoBehaviour
{
    public float speed;
    private int count;
    private void Awake()
    {
        count = 0;
    }
    private void Update()
    {
        transform.position = new Vector3(0, -25 + (count * speed), 0);
        count++;
    }
}
