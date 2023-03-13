using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeAllTime : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> MeshProUguis;
    
    void FixedUpdate()
    {
        string time =  DateTime.Now.ToString("t");
        foreach (TextMeshProUGUI tm in MeshProUguis)
        {
            tm.text = time;
        }
    }
}
