using UnityEngine;
using UnityEngine.UI;

public abstract class Window : MonoBehaviour
{
    [field: SerializeField] protected CanvasGroup WindowGroup { get; set; }

    [field: SerializeField] protected Button ActionButton { get; set; }

    private void OnEnable()
    {
        ActionButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        ActionButton.onClick.RemoveListener(OnButtonClick);
    }

    public void Open()
    {
        WindowGroup.alpha = 1.0f;
        WindowGroup.blocksRaycasts = true;
        ActionButton.interactable = true;
    }

    public void Close()
    {
        WindowGroup.alpha = 0;
        WindowGroup.blocksRaycasts = false;
        ActionButton.interactable = false;
    }

    protected abstract void OnButtonClick();
}
