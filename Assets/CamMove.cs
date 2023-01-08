using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamMove : MonoBehaviour
{
    public float range;
    private void Update()
    {
        try
        {
            transform.position = GameObject.Find("Player").transform.position + Vector3.back * range;
        }
        catch { }
        if (!GameObject.Find("Player") && Input.GetKey(KeyCode.Space)) SceneManager.LoadScene(1);
    }
}
