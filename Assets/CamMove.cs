using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float range;
    private void Update()
    {
        transform.position = GameObject.Find("Player").transform.position + Vector3.back * range;
    }
}
