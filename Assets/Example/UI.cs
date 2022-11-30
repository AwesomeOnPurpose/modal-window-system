using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI Instance;

    public ModalWindowContent ModalWindow;
    public ModalWindowDesign ModalDesign;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            ModalWindow = FindObjectOfType<ModalWindowContent>();
            ModalDesign = FindObjectOfType<ModalWindowDesign>();
        }
    }
}
