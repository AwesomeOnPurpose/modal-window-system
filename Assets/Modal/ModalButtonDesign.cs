using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ModalButtonDesign
{
    public Color BackgroundColor = Color.white;
    public Sprite Background;
    public FontDesign Text;
    public bool OverwriteDefaults = false;
    public ColorBlock ColorBlock = ColorBlock.defaultColorBlock;

    public void UpdateButton(Button button, TextMeshProUGUI buttonText)
    {
        button.image.color = BackgroundColor;

        if (Background != null)
        {
            button.image.sprite = Background;
        }

        if (OverwriteDefaults)
        {
            button.colors = ColorBlock;
        }

        Text.UpdateFont(buttonText);
    }
}
