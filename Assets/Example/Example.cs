using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] Sprite image;
    [SerializeField] ModalPalette defaultPalette;
    [SerializeField] ModalPalette palette;

    public void ShowExample1()
    {
        StepOne();
    }

    public void UpdateDesign()
    {
        UI.Instance.ModalDesign.SetPalette(palette);
    }

    public void ResetDesign()
    {
        UI.Instance.ModalDesign.SetPalette(defaultPalette);
    }

    public void ShowConfirmation()
    {
        UI.Instance.ModalWindow.ShowConfirm(ThisMessage);
    }

    void ThisMessage()
    {
        Debug.Log("This message called from Confirmation dialog");
    }

    void StepOne()
    {
        UI.Instance.ModalWindow
            .SetHeader("Tutorial")
            .SetVerticalContent("This is an example of a modal window. This is the vertical layout with an image.", image)
            .SetConfirmButton("OK", StepTwo)
            .Show();
    }

    public void StepTwo()
    {
        UI.Instance.ModalWindow
            .SetHorizontalContent("This is the horizontal layout with no image and no header text.")
            .SetConfirmButton("OK", StepThree)
            .SetCancelButton("Go back", StepOne)
            .Show();
    }

    public void StepThree()
    {
        UI.Instance.ModalWindow
            .SetHeader("Tutorial")
            .SetHorizontalContent("This is the horizontal layout with an image and header text.", image)
            .SetConfirmButton("OK, close")
            .SetCancelButton("Go back", StepTwo)
            .Show();
    }
}
