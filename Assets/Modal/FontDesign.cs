using UnityEngine;
using TMPro;

[System.Serializable]
public class FontDesign
{
    public TMP_FontAsset Font;
    public Color FontColor = Color.white;

    public void UpdateFont(TextMeshProUGUI text = null)
    {
        text.color = FontColor;
        if(text != null)
        {
            text.font = Font;
        }
    }
}
