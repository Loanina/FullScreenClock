using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePrewieColor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void ChangeColor(Color color)
    {
        text.color = color;
    }
}
