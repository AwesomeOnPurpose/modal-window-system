using System;
using UnityEngine;
using UnityEngine.UI;

public class ModalActions : MonoBehaviour
{
    [SerializeField] ModalWindowContent modalWindow;

    [SerializeField] Button confirmButton;
    [SerializeField] Button cancelButton;
    [SerializeField] Button altButton;

    Action _onConfirmAction;
    Action _onCancelAction;
    Action _onAltAction;

    private void Awake()
    {
        if (!modalWindow)
        {
            Debug.LogError("Modal Window Content missing", gameObject);
            return;
        }

        if (!confirmButton || !cancelButton || !altButton)
        {
            Debug.LogError("One or more button missing", gameObject);
            return;
        }
        confirmButton.onClick.AddListener(Confirm);
        cancelButton.onClick.AddListener(Cancel);
        altButton.onClick.AddListener(Alternative);
    }

    private void OnDisable()
    {
        confirmButton.onClick.RemoveListener(Confirm);
        cancelButton.onClick.RemoveListener(Cancel);
        altButton.onClick.RemoveListener(Alternative);
    }

    public void SetConfirmAction(Action action) => _onConfirmAction = action;
    public void SetCancelAction(Action action) => _onCancelAction = action;
    public void SetAltAction(Action action) => _onAltAction = action;

    void Confirm()
    {
        modalWindow?.Close();
        _onConfirmAction?.Invoke();
    }

    void Cancel()
    {
        modalWindow?.Close();
        _onCancelAction?.Invoke();
    }

    void Alternative()
    {
        modalWindow?.Close();
        _onAltAction?.Invoke();
    }
}
