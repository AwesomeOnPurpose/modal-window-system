using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class ModalWindowContent : MonoBehaviour
{
    [SerializeField] GameObject window;
    [SerializeField] GameObject header;
    [SerializeField] TextMeshProUGUI headerText;

    [SerializeField] GameObject vContent;
    [SerializeField] Image vContentImage;
    [SerializeField] TextMeshProUGUI vContentText;

    [SerializeField] GameObject hContent;
    [SerializeField] GameObject hContentImageArea;
    [SerializeField] Image hContentImage;
    [SerializeField] TextMeshProUGUI hContentText;

    [SerializeField] Button confirmButton;
    [SerializeField] TextMeshProUGUI confirmButtonText;
    [SerializeField] Button cancelButton;
    [SerializeField] TextMeshProUGUI cancelButtonText;
    [SerializeField] Button altButton;
    [SerializeField] TextMeshProUGUI altButtonText;

    [SerializeField] ModalActions actions;

    private void Awake()
    {
        ResetWindow();
    }

    private void ResetWindow()
    {
        window.SetActive(false);
        header.SetActive(false);
        headerText.SetText("");
        headerText.gameObject.SetActive(false);
        vContent.SetActive(false);
        vContentImage.gameObject.SetActive(false);
        vContentText.SetText("");
        vContentText.gameObject.SetActive(false);
        hContent.SetActive(false);
        hContentImageArea.SetActive(false);
        hContentText.SetText("");
        hContentText.gameObject.SetActive(false);
        confirmButtonText.SetText("OK");
        confirmButton.gameObject.SetActive(true);
        cancelButtonText.SetText("Cancel");
        cancelButton.gameObject.SetActive(false);
        altButtonText.SetText("OK");
        altButton.gameObject.SetActive(false);
    }

    public void Close()
    {
        window.SetActive(false);
        ResetWindow();
    }

    public ModalWindowContent SetHeader(string headerText)
    {
        this.headerText.SetText(headerText);
        this.headerText.gameObject.SetActive(true);
        header.SetActive(true);
        return this;
    }

    public ModalWindowContent SetHorizontalContent(string message = "", Sprite imageToShow = null)
    {
        if (imageToShow != null)
        {
            hContentImage.sprite = imageToShow;
            hContentImageArea.SetActive(true);
            hContentImage.gameObject.SetActive(true);
        }
        if (!string.IsNullOrEmpty(message))
        {
            hContentText.SetText(message);
            hContentText.gameObject.SetActive(true);
        }
        hContent.SetActive(true);
        return this;
    }


    public ModalWindowContent SetVerticalContent(string message = "", Sprite imageToShow = null)
    {
        if(imageToShow != null)
        {
            vContentImage.sprite = imageToShow;
            vContentImage.gameObject.SetActive(true);
        }
        if (!string.IsNullOrEmpty(message))
        {
            vContentText.SetText(message);
            vContentText.gameObject.SetActive(true);
        }
        vContent.SetActive(true);
        return this;
    }

    public ModalWindowContent SetConfirmButton(string text, Action action = null)
    {
        confirmButtonText.SetText(text);
        confirmButton.gameObject.SetActive(true);
        confirmButton.transform.SetAsFirstSibling();
        actions.SetConfirmAction(action);
        return this;
    }

    public ModalWindowContent SetCancelButton(string text, Action action = null)
    {
        cancelButtonText.SetText(text);
        cancelButton.gameObject.SetActive(true);
        cancelButton.transform.SetAsFirstSibling();
        actions.SetCancelAction(action);
        return this;
    }

    public ModalWindowContent SetAltButton(string text, Action action = null)
    {
        altButtonText.SetText(text);
        altButton.gameObject.SetActive(true);
        altButton.transform.SetAsFirstSibling();
        actions.SetAltAction(action);
        return this;
    }

    public void Show()
    {
        window.SetActive(true);
    }

    public void ShowConfirm(Action action)
    {
        ResetWindow();
        SetHorizontalContent("Are you sure?")
            .SetConfirmButton("Yes", action)
            .SetCancelButton("Cancel")
            .Show();
    }

}
