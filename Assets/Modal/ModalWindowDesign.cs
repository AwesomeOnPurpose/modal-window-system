using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModalWindowDesign : MonoBehaviour
{
    [SerializeField] ModalPalette defaultPalette;
    [Space(10)]
    [SerializeField] Image modalBackgroundImage;
    [SerializeField] TextMeshProUGUI headerText;
    [SerializeField] Image headerBackgroundImage;
    [SerializeField] Image hImageBackground;
    [SerializeField] TextMeshProUGUI hContentText;
    [SerializeField] TextMeshProUGUI vContentText;

    [SerializeField] Button confirmButton;
    [SerializeField] TextMeshProUGUI confirmButtonText;

    [SerializeField] Button cancelButton;
    [SerializeField] TextMeshProUGUI cancelButtonText;

    [SerializeField] Button altButton;
    [SerializeField] TextMeshProUGUI altButtonText;

    public void Awake()
    {
        SetPalette(defaultPalette);
    }

    public void SetPalette(ModalPalette newPalette)
    {
        if (!newPalette) return;
        defaultPalette = newPalette;
        UpdateDesign(newPalette);
    }

    void UpdateDesign(ModalPalette palette)
    {
        modalBackgroundImage.color = palette.ModalBackground;
        headerBackgroundImage.color = palette.HeaderBackground;
        hImageBackground.color = palette.H_ImageBackground;

        palette.HeaderFont.UpdateFont(headerText);
        palette.H_ContentFont.UpdateFont(hContentText);
        palette.V_ContentFont.UpdateFont(vContentText);

        palette.ConfirmButton.UpdateButton(confirmButton, confirmButtonText);
        palette.CancelButton.UpdateButton(cancelButton, cancelButtonText);
        palette.AltButton.UpdateButton(altButton, altButtonText);
    }
}