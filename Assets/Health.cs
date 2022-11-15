using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    public VarByte hp;
    public RawImage[] raw;
    private void Update()
    {
        switch (hp.value)
        {
            case 1:
                raw[0].color = Color.red;
                raw[2].color = raw[1].color = Color.white;
                break ;
            case 2:
                raw[1].color = raw[0].color = Color.red;
                raw[2].color = Color.white;
                break;
            case 3:
                raw[2].color = raw[1].color = raw[0].color = Color.red;
                break;
            default:
                raw[2].color = raw[1].color = raw[0].color = Color.white;
                break;
        }
    }
}
