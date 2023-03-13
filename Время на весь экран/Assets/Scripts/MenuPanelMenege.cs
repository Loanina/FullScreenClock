using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuPanelMenege : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject ColorPanel;
    [SerializeField] private FlexibleColorPicker ColorPicker;
    [SerializeField] private TextMeshProUGUI text;

    public void OpenCloseMenuPanel()
    {
        if (!ColorPanel.activeSelf)
        {
            MenuPanel.SetActive(!MenuPanel.activeSelf);
            ColorPicker.SetColor(Color.red);
            text.color = Color.red;
        }
    }
}
