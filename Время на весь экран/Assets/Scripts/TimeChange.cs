using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeChange : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Clock;
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject ColorPanel;

    void Update()
    {
        Clock.text = DateTime.Now.ToString("t");
    }

    private void Start()
    {
        MenuPanel.SetActive(false);
        ColorPanel.SetActive(false);
    }
}
