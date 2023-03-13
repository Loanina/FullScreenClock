using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UIElements;

public class FontsMeneger : MonoBehaviour
{
    public static TMP_FontAsset SelectedFont;
    [SerializeField] private GameObject ColorPanel;
    public TextMeshProUGUI PrewText;
    
    public void SetFont(TextMeshProUGUI text)
    {
        if (!ColorPanel.activeSelf)
        {
            ColorPanel.SetActive(true);
            SelectedFont = text.font;
            PrewText.font = SelectedFont;
        }
    }
}
