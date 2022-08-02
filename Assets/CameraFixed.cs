using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixed : MonoBehaviour
{    private void Update()
    {
        transform.SetPositionAndRotation(transform.position, Quaternion.identity);   
    }
}
