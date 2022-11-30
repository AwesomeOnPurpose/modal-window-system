using UnityEngine;

[CreateAssetMenu]
public class ModalPalette : ScriptableObject
{
    public Color ModalBackground = new Color32(0x62, 0x9E, 0xCA, 0xFF);
    public FontDesign HeaderFont;
    public Color HeaderBackground = new Color32(0x00, 0x00, 0x00, 0xAE);
    public Color H_ImageBackground = new Color32(0x00, 0x00, 0x00, 0x50);
    public FontDesign H_ContentFont;
    public FontDesign V_ContentFont;
    public ModalButtonDesign ConfirmButton;
    public ModalButtonDesign CancelButton;
    public ModalButtonDesign AltButton;
}