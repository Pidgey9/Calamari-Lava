using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinTimer : MonoBehaviour
{
    float timer;
    TextMeshProUGUI text;
    void Awake()
    {
        timer = 0;
        text = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (GameObject.Find("Win").GetComponent<TextMeshProUGUI>().enabled == false) timer += Time.deltaTime;
        text.text = timer.ToString();
    }
}
