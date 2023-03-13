using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TextView : MonoBehaviour
{
    [SerializeField] private GameObject ColorPanel;
    [SerializeField] private GameObject FontPanel;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private TextMeshProUGUI MainText;
    [SerializeField] private FlexibleColorPicker ColorPicker;

    public void ClosePanel()
    {
        ColorPanel.SetActive(false);
        ColorPicker.SetColor(Color.red);
    }

    public void SetTheme() {
        MainText.color = Text.color;
        MainText.font = FontsMeneger.SelectedFont;
        MainText.UpdateFontAsset();
        ColorPanel.SetActive(false);
        ColorPicker.color = Color.red;
        Text.color = Color.red;
        FontPanel.SetActive(false);
    }
}
